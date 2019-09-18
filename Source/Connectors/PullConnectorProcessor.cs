/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Linq;
using grpc = Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client;
using System.Threading;
using Dolittle.Logging;
using Dolittle.Protobuf;
using static Dolittle.TimeSeries.Runtime.Connectors.Grpc.Client.PullConnector;
using System;
using Dolittle.Collections;
using Dolittle.Runtime.Application;
using Dolittle.TimeSeries.DataTypes.Protobuf;
using Dolittle.TimeSeries.Runtime.DataPoints;
using Dolittle.TimeSeries.Runtime.Identity;
using Google.Protobuf.WellKnownTypes;

namespace Dolittle.TimeSeries.Runtime.Connectors
{
    /// <summary>
    /// Represents a processor that process a <see cref="PullConnector"/>
    /// </summary>
    public class PullConnectorProcessor : IDisposable
    {
        readonly PullConnector _connector;
        readonly IClientFor<PullConnectorClient> _client;
        readonly ILogger _logger;
        readonly IOutputStreams _outputStreams;
        readonly ITimeSeriesMapper _timeSeriesMapper;
        CancellationTokenSource _cancellationTokenSource;
        System.Timers.Timer _timer;

        /// <summary>
        /// Initializes a new instance of <see cref="PullConnectorProcessor"/>
        /// </summary>
        /// <param name="connector"><see cref="PullConnector"/> to process for</param>
        /// <param name="client"><see cref="IClientFor{T}">Client for</see> <see cref="PullConnectorClient"/></param>
        /// <param name="outputStreams">All <see cref="IOutputStreams"/></param>
        /// <param name="timeSeriesMapper"><see cref="ITimeSeriesMapper"/> for mapping data points</param>
        /// <param name="logger"><see cref="ILogger"/> for logging</param>
        public PullConnectorProcessor(
            PullConnector connector,
            IClientFor<PullConnectorClient> client,
            IOutputStreams outputStreams,
            ITimeSeriesMapper timeSeriesMapper,
            ILogger logger)
        {
            _logger = logger;
            _connector = connector;
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.Token.ThrowIfCancellationRequested();
            _timeSeriesMapper = timeSeriesMapper;
            _client = client;
            _outputStreams = outputStreams;

            _timer = new System.Timers.Timer(connector.Interval);
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Elapsed += (s, e) => Process();

            _logger.Information($"Starting '{_connector.Name}'");

            _timer.Start();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _logger.Information($"Disposing processor for '{_connector.Id}'");
            if (_timer != null) Stop();
            _timer?.Dispose();
            _cancellationTokenSource?.Dispose();
            _timer = null;
            _cancellationTokenSource = null;
        }

        /// <summary>
        /// Stop processing
        /// </summary>
        public void Stop()
        {
            _logger.Information($"Stopping processor for '{_connector.Id}'");
            _timer?.Stop();
            _cancellationTokenSource?.Cancel();
            _timer = null;
            _cancellationTokenSource = null;
        }

        void Process()
        {
            if (_connector.Tags.Count() == 0)
            {
                _logger.Warning($"Connector '{_connector.Name}' does not have any tags - ignoring it completely");
                return;
            }

            if (_cancellationTokenSource.Token.IsCancellationRequested)
            {
                _timer.Stop();
                return;
            }

            _logger.Information($"Call connector '{_connector.Name}' - '{_connector.Id}'");
            var request = new grpc.PullRequest
            {
                ConnectorId = _connector.Id.ToProtobuf(),
            };
            request.Tags.Add(_connector.Tags.Select(_ => _.Value));
            var result = _client.Instance.Pull(request);
            result.Data.ForEach(tagDataPoint =>
            {
                if (!_timeSeriesMapper.HasTimeSeriesFor(_connector.Name, tagDataPoint.Tag))
                    _logger.Information($"Unidentified tag '{tagDataPoint.Tag}' from '{_connector.Name}'");
                else
                {

                    var dataPoint = new DataPoint
                    {
                        TimeSeries = _timeSeriesMapper.GetTimeSeriesFor(_connector.Name, tagDataPoint.Tag).ToProtobuf(),
                        Value = tagDataPoint.Value,
                        Timestamp = Timestamp.FromDateTimeOffset(DateTimeOffset.UtcNow)
                    };
                    _outputStreams.Write(dataPoint);
                }
            });
        }
    }
}
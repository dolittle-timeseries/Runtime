/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Dolittle.Collections;
using Dolittle.Lifecycle;
using Dolittle.Logging;
using Dolittle.Protobuf;
using Dolittle.TimeSeries.Runtime.Identity;
using Dolittle.TimeSeries.Runtime.State;
using Google.Protobuf.WellKnownTypes;
using grpc = Dolittle.TimeSeries.DataPoints.Runtime;
using grpcDataTypes = Dolittle.TimeSeries.DataTypes.Runtime;
using Dolittle.TimeSeries.Runtime.DataTypes;

namespace Dolittle.TimeSeries.Runtime.Connectors
{
    /// <summary>
    /// Represents an implementation of <see cref="ITagDataPointCoordinator"/>
    /// </summary>
    [Singleton]
    public class TagDataPointCoordinator : ITagDataPointCoordinator
    {
        readonly ITimeSeriesMapper _timeSeriesMapper;
        readonly IDataPointsState _dataPointsState;
        readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of <see cref="TagDataPointCoordinator"/>
        /// </summary>
        /// <param name="timeSeriesMapper"><see cref="ITimeSeriesMapper"/> for identity mapping of TimeSeries</param>
        /// <param name="dataPointsState"><see cref="IDataPointsState"/> for working with the state</param>
        /// <param name="logger"><see cref="ILogger"/> for logging</param>
        public TagDataPointCoordinator(
            ITimeSeriesMapper timeSeriesMapper,
            IDataPointsState dataPointsState,
            ILogger logger)
        {
            _timeSeriesMapper = timeSeriesMapper;
            _logger = logger;
            _dataPointsState = dataPointsState;
        }

        /// <inheritdoc/>
        public void Handle(string connectorName, IEnumerable<grpc.TagDataPoint> dataPoints)
        {
            dataPoints.ForEach(tagDataPoint =>
            {
                if (!_timeSeriesMapper.HasTimeSeriesFor(connectorName, tagDataPoint.Tag))
                {
                    _logger.Information($"Unidentified tag '{tagDataPoint.Tag}' from '{connectorName}'");
                }
                else
                {
                    _logger.Information("DataPoint received");
                    var timeSeriesId = _timeSeriesMapper.GetTimeSeriesFor(connectorName, tagDataPoint.Tag);

                    var dataPoint = new grpcDataTypes.DataPoint
                    {
                        TimeSeries = timeSeriesId.ToProtobuf(),
                        Value = tagDataPoint.Value,
                        Timestamp = Timestamp.FromDateTimeOffset(DateTimeOffset.UtcNow)
                    };
                    _dataPointsState.Set(dataPoint.ToMicroservice());
                }
            });
        }
    }
}
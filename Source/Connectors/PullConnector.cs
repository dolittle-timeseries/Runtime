/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace Dolittle.TimeSeries.Runtime.Connectors
{
    /// <summary>
    /// Defines a pull connector
    /// </summary>
    public class PullConnector
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PullConnector"/>
        /// </summary>
        /// <param name="id">Unique <see cref="ConnectorId"/></param>
        /// <param name="name">Name of the connector</param>
        /// <param name="interval">Interval to pull in milliseconds</param>
        public PullConnector(
            ConnectorId id,
            string name,
            int interval)
        {
            Id = id;
            Name = name;
            Interval = interval;
        }

        /// <summary>
        /// Gets the <see cref="ConnectorId"/> for the <see cref="PullConnector"/>
        /// </summary>
        public ConnectorId Id { get; }

        /// <summary>
        /// Gets the name of the <see cref="PullConnector"/>
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Interval to pull in milliseconds
        /// </summary>
        public int Interval { get; }
    }
}
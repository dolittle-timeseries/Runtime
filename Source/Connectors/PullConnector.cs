/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


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
        public PullConnector(ConnectorId id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Gets the <see cref="ConnectorId"/> for the <see cref="PullConnector"/>
        /// </summary>
        public ConnectorId Id { get; }

        /// <summary>
        /// Gets the name of the <see cref="PullConnector"/>
        /// </summary>
        public string Name { get; }

    }
}
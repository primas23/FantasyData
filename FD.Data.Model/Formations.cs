// <copyright file="Formations.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The team formations class
    /// </summary>
    public class Formations
    {
        /// <summary>
        /// Gets or sets the formation1523.
        /// </summary>
        /// <value>
        /// The formation1523.
        /// </value>
        [JsonProperty("1-5-2-3")]
        public IList<IList<int>> Formation1523 { get; set; }

        /// <summary>
        /// Gets or sets the formation1532.
        /// </summary>
        /// <value>
        /// The formation1532.
        /// </value>
        [JsonProperty("1-5-3-2")]
        public IList<IList<int>> Formation1532 { get; set; }

        /// <summary>
        /// Gets or sets the formation1352.
        /// </summary>
        /// <value>
        /// The formation1352.
        /// </value>
        [JsonProperty("1-3-5-2")]
        public IList<IList<int>> Formation1352 { get; set; }

        /// <summary>
        /// Gets or sets the formation1253.
        /// </summary>
        /// <value>
        /// The formation1253.
        /// </value>
        [JsonProperty("1-2-5-3")]
        public IList<IList<int>> Formation1253 { get; set; }

        /// <summary>
        /// Gets or sets the formation1451.
        /// </summary>
        /// <value>
        /// The formation1451.
        /// </value>
        [JsonProperty("1-4-5-1")]
        public IList<IList<int>> Formation1451 { get; set; }

        /// <summary>
        /// Gets or sets the formation1541.
        /// </summary>
        /// <value>
        /// The formation1541.
        /// </value>
        [JsonProperty("1-5-4-1")]
        public IList<IList<int>> Formation1541 { get; set; }

        /// <summary>
        /// Gets or sets the formation1433.
        /// </summary>
        /// <value>
        /// The formation1433.
        /// </value>
        [JsonProperty("1-4-3-3")]
        public IList<IList<int>> Formation1433 { get; set; }

        /// <summary>
        /// Gets or sets the formation1343.
        /// </summary>
        /// <value>
        /// The formation1343.
        /// </value>
        [JsonProperty("1-3-4-3")]
        public IList<IList<int>> Formation1343 { get; set; }

        /// <summary>
        /// Gets or sets the formation1442.
        /// </summary>
        /// <value>
        /// The formation1442.
        /// </value>
        [JsonProperty("1-4-4-2")]
        public IList<IList<int>> Formation1442 { get; set; }
    }
}
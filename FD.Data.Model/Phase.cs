// <copyright file="Phase.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    using FD.Data.Common.Contracts;

    /// <summary>
    /// The Phase class
    /// </summary>
    public class Phase : IIdentifier<int>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the start event.
        /// </summary>
        /// <value>
        /// The start event.
        /// </value>
        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        /// <summary>
        /// Gets or sets the stop event.
        /// </summary>
        /// <value>
        /// The stop event.
        /// </value>
        [JsonProperty("stop_event")]
        public int StopEvent { get; set; }
    }
}
// <copyright file="CurrentEventFixture.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The current event fixture of the team
    /// </summary>
    public class CurrentEventFixture
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
        /// Gets or sets a value indicating whether this team is playing home.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is home; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        /// <summary>
        /// Gets or sets the day when the team is playing.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        [JsonProperty("day")]
        public int Day { get; set; }

        /// <summary>
        /// Gets or sets the round event day.
        /// </summary>
        /// <value>
        /// The event day.
        /// </value>
        [JsonProperty("event_day")]
        public int EventDay { get; set; }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        [JsonProperty("month")]
        public int Month { get; set; }

        /// <summary>
        /// Gets or sets the opponent`s id.
        /// </summary>
        /// <value>
        /// The opponent.
        /// </value>
        [JsonProperty("opponent")]
        public int Opponent { get; set; }
    }
}
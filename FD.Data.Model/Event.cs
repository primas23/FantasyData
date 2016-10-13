// <copyright file="Event.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using System;

    using Newtonsoft.Json;

    using FD.Data.Common.Contracts;

    /// <summary>
    /// The event class
    /// </summary>
    public class Event : IIdentifier<int>
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
        /// Gets or sets the deadline time.
        /// </summary>
        /// <value>
        /// The deadline time.
        /// </value>
        [JsonProperty("deadline_time")]
        public DateTime DeadlineTime { get; set; }

        /// <summary>
        /// Gets or sets the average entry score.
        /// </summary>
        /// <value>
        /// The average entry score.
        /// </value>
        [JsonProperty("average_entry_score")]
        public int AverageEntryScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Event"/> is finished.
        /// </summary>
        /// <value>
        ///   <c>true</c> if finished; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [data checked].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [data checked]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("data_checked")]
        public bool DataChecked { get; set; }

        /// <summary>
        /// Gets or sets the highest scoring entry.
        /// </summary>
        /// <value>
        /// The highest scoring entry.
        /// </value>
        [JsonProperty("highest_scoring_entry")]
        public int? HighestScoringEntry { get; set; }

        /// <summary>
        /// Gets or sets the deadline time epoch.
        /// </summary>
        /// <value>
        /// The deadline time epoch.
        /// </value>
        [JsonProperty("deadline_time_epoch")]
        public int DeadlineTimeEpoch { get; set; }

        /// <summary>
        /// Gets or sets the deadline time game offset.
        /// </summary>
        /// <value>
        /// The deadline time game offset.
        /// </value>
        [JsonProperty("deadline_time_game_offset")]
        public int DeadlineTimeGameOffset { get; set; }

        /// <summary>
        /// Gets or sets the deadline time formatted.
        /// </summary>
        /// <value>
        /// The deadline time formatted.
        /// </value>
        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        /// <summary>
        /// Gets or sets the highest score.
        /// </summary>
        /// <value>
        /// The highest score.
        /// </value>
        [JsonProperty("highest_score")]
        public int? HighestScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is previous.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is previous; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_previous")]
        public bool IsPrevious { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is current.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is current; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_current")]
        public bool IsCurrent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is next.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is next; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_next")]
        public bool IsNext { get; set; }
    }
}

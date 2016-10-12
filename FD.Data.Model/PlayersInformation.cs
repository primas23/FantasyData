// <copyright file="PlayerInformation.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The PlayerInformation class
    /// </summary>
    public class PlayersInformation
    {
        /// <summary>
        /// Gets or sets the phases.
        /// </summary>
        /// <value>
        /// The phases.
        /// </value>
        [JsonProperty("phases")]
        public virtual IList<Phase> Phases { get; set; }

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        [JsonProperty("elements")]
        public virtual IList<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the game settings.
        /// </summary>
        /// <value>
        /// The game settings.
        /// </value>
        [JsonProperty("game-settings")]
        public virtual GameSettings GameSettings { get; set; }

        /// <summary>
        /// Gets or sets the total players.
        /// </summary>
        /// <value>
        /// The total players.
        /// </value>
        [JsonProperty("total-players")]
        public int TotalPlayers { get; set; }

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        /// <value>
        /// The teams.
        /// </value>
        [JsonProperty("teams")]
        public virtual IList<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the player types.
        /// </summary>
        /// <value>
        /// The player types.
        /// </value>
        [JsonProperty("element_types")]
        public virtual IList<PlayerType> PlayerTypes { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>
        /// The events.
        /// </value>
        [JsonProperty("events")]
        public virtual IList<Event> Events { get; set; }
    }
}
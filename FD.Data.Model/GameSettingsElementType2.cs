// <copyright file="GameSettingsElementType2.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Game Settings Element Type 2
    /// </summary>
    public class GameSettingsElementType2
    {
        /// <summary>
        /// Gets or sets the scoring clean sheets.
        /// </summary>
        /// <value>
        /// The scoring clean sheets.
        /// </value>
        [JsonProperty("scoring_clean_sheets")]
        public int ScoringCleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the squad minimum play.
        /// </summary>
        /// <value>
        /// The squad minimum play.
        /// </value>
        [JsonProperty("squad_min_play")]
        public int SquadMinPlay { get; set; }

        /// <summary>
        /// Gets or sets the scoring goals conceded.
        /// </summary>
        /// <value>
        /// The scoring goals conceded.
        /// </value>
        [JsonProperty("scoring_goals_conceded")]
        public int ScoringGoalsConceded { get; set; }

        /// <summary>
        /// Gets or sets the scoring goals scored.
        /// </summary>
        /// <value>
        /// The scoring goals scored.
        /// </value>
        [JsonProperty("scoring_goals_scored")]
        public int ScoringGoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the squad maximum play.
        /// </summary>
        /// <value>
        /// The squad maximum play.
        /// </value>
        [JsonProperty("squad_max_play")]
        public int SquadMaxPlay { get; set; }

        /// <summary>
        /// Gets or sets the BPS goals scored.
        /// </summary>
        /// <value>
        /// The BPS goals scored.
        /// </value>
        [JsonProperty("bps_goals_scored")]
        public int BpsGoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the BPS clean sheets.
        /// </summary>
        /// <value>
        /// The BPS clean sheets.
        /// </value>
        [JsonProperty("bps_clean_sheets")]
        public int BpsCleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the squad select.
        /// </summary>
        /// <value>
        /// The squad select.
        /// </value>
        [JsonProperty("squad_select")]
        public int SquadSelect { get; set; }
    }
}
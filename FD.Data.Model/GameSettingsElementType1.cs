using System.Collections.Generic;
using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class GameSettingsElementType1
    {

        [JsonProperty("scoring_clean_sheets")]
        public int ScoringCleanSheets { get; set; }

        [JsonProperty("squad_min_play")]
        public int SquadMinPlay { get; set; }

        [JsonProperty("bps_clean_sheets")]
        public int BpsCleanSheets { get; set; }

        [JsonProperty("scoring_goals_conceded")]
        public int ScoringGoalsConceded { get; set; }

        [JsonProperty("scoring_goals_scored")]
        public int ScoringGoalsScored { get; set; }

        [JsonProperty("squad_max_play")]
        public int SquadMaxPlay { get; set; }

        [JsonProperty("bps_goals_scored")]
        public int BpsGoalsScored { get; set; }

        [JsonProperty("ui_shirt_specific")]
        public bool UiShirtSpecific { get; set; }

        [JsonProperty("squad_select")]
        public int SquadSelect { get; set; }

        [JsonProperty("sub_positions_locked")]
        public IList<int> SubPositionsLocked { get; set; }
    }
}
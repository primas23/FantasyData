using System.Collections.Generic;
using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class Team
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("current_event_fixture")]
        public IList<CurrentEventFixture> CurrentEventFixture { get; set; }

        [JsonProperty("next_event_fixture")]
        public IList<NextEventFixture> NextEventFixture { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("played")]
        public int Played { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }

        [JsonProperty("loss")]
        public int Loss { get; set; }

        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("form")]
        public object Form { get; set; }

        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        [JsonProperty("strength_overall_home")]
        public int StrengthOverallHome { get; set; }

        [JsonProperty("strength_overall_away")]
        public int StrengthOverallAway { get; set; }

        [JsonProperty("strength_attack_home")]
        public int StrengthAttackHome { get; set; }

        [JsonProperty("strength_attack_away")]
        public int StrengthAttackAway { get; set; }

        [JsonProperty("strength_defence_home")]
        public int StrengthDefenceHome { get; set; }

        [JsonProperty("strength_defence_away")]
        public int StrengthDefenceAway { get; set; }

        [JsonProperty("team_division")]
        public int TeamDivision { get; set; }
    }
}
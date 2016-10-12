using System.Collections.Generic;
using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class PlayerInformation
    {

        [JsonProperty("phases")]
        public IList<Phase> Phases { get; set; }

        [JsonProperty("elements")]
        public IList<Element> Elements { get; set; }

        [JsonProperty("game-settings")]
        public GameSettings GameSettings { get; set; }

        [JsonProperty("total-players")]
        public int TotalPlayers { get; set; }

        [JsonProperty("teams")]
        public IList<Team> Teams { get; set; }

        [JsonProperty("element_types")]
        public IList<ElementType> ElementTypes { get; set; }

        [JsonProperty("events")]
        public IList<Event> Events { get; set; }
    }
}
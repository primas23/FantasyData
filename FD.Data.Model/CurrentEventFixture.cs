using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class CurrentEventFixture
    {

        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("event_day")]
        public int EventDay { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("opponent")]
        public int Opponent { get; set; }
    }
}
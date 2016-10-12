using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class Phase
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("stop_event")]
        public int StopEvent { get; set; }
    }
}
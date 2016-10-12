using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class GameSettings
    {

        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("element_type")]
        public GameSettingsElementType ElementType { get; set; }
    }
}
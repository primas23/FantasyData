using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class GameSettingsElementType
    {

        [JsonProperty("1")]
        public GameSettingsElementType1 GameSettingsElementType1 { get; set; }

        [JsonProperty("2")]
        public GameSettingsElementType2 GameSettingsElementType2 { get; set; }

        [JsonProperty("3")]
        public GameSettingsElementType3 GameSettingsElementType3 { get; set; }

        [JsonProperty("4")]
        public GameSettingsElementType4 GameSettingsElementType4 { get; set; }
    }
}
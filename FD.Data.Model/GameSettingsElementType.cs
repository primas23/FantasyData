// <copyright file="GameSettingsElementType.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// Game Settings Element Type
    /// </summary>
    public class GameSettingsElementType
    {
        /// <summary>
        /// Gets or sets the game settings element type1.
        /// </summary>
        /// <value>
        /// The game settings element type1.
        /// </value>
        [JsonProperty("1")]
        public GameSettingsElementType1 GameSettingsElementType1 { get; set; }

        /// <summary>
        /// Gets or sets the game settings element type2.
        /// </summary>
        /// <value>
        /// The game settings element type2.
        /// </value>
        [JsonProperty("2")]
        public GameSettingsElementType2 GameSettingsElementType2 { get; set; }

        /// <summary>
        /// Gets or sets the game settings element type3.
        /// </summary>
        /// <value>
        /// The game settings element type3.
        /// </value>
        [JsonProperty("3")]
        public GameSettingsElementType3 GameSettingsElementType3 { get; set; }

        /// <summary>
        /// Gets or sets the game settings element type4.
        /// </summary>
        /// <value>
        /// The game settings element type4.
        /// </value>
        [JsonProperty("4")]
        public GameSettingsElementType4 GameSettingsElementType4 { get; set; }
    }
}
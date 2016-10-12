// <copyright file="GameSettings.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Game Settings
    /// </summary>
    public class GameSettings
    {
        /// <summary>
        /// Gets or sets the game.
        /// </summary>
        /// <value>
        /// The game.
        /// </value>
        [JsonProperty("game")]
        public Game Game { get; set; }

        /// <summary>
        /// Gets or sets the type of the element.
        /// </summary>
        /// <value>
        /// The type of the element.
        /// </value>
        [JsonProperty("element_type")]
        public GameSettingsElementType ElementType { get; set; }
    }
}
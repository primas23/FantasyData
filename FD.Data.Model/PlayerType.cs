// <copyright file="PlayerType.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The player types
    /// </summary>
    public class PlayerType
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the singular name.
        /// </summary>
        /// <value>
        /// The name of the singular.
        /// </value>
        [JsonProperty("singular_name")]
        public string SingularName { get; set; }

        /// <summary>
        /// Gets or sets the singular name short.
        /// </summary>
        /// <value>
        /// The singular name short.
        /// </value>
        [JsonProperty("singular_name_short")]
        public string SingularNameShort { get; set; }

        /// <summary>
        /// Gets or sets the plural name.
        /// </summary>
        /// <value>
        /// The name of the plural.
        /// </value>
        [JsonProperty("plural_name")]
        public string PluralName { get; set; }

        /// <summary>
        /// Gets or sets the plural name short.
        /// </summary>
        /// <value>
        /// The plural name short.
        /// </value>
        [JsonProperty("plural_name_short")]
        public string PluralNameShort { get; set; }
    }
}
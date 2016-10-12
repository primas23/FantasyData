// <copyright file="Team.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The Team class
    /// </summary>
    public class Team
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
        /// Gets or sets the current event fixture.
        /// </summary>
        /// <value>
        /// The current event fixture.
        /// </value>
        [JsonProperty("current_event_fixture")]
        public IList<CurrentEventFixture> CurrentEventFixture { get; set; }

        /// <summary>
        /// Gets or sets the next event fixture.
        /// </summary>
        /// <value>
        /// The next event fixture.
        /// </value>
        [JsonProperty("next_event_fixture")]
        public IList<NextEventFixture> NextEventFixture { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Team"/> is unavailable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if unavailable; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        /// <summary>
        /// Gets or sets the strength.
        /// </summary>
        /// <value>
        /// The strength.
        /// </value>
        [JsonProperty("strength")]
        public int Strength { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the played.
        /// </summary>
        /// <value>
        /// The played.
        /// </value>
        [JsonProperty("played")]
        public int Played { get; set; }

        /// <summary>
        /// Gets or sets the win.
        /// </summary>
        /// <value>
        /// The win.
        /// </value>
        [JsonProperty("win")]
        public int Win { get; set; }

        /// <summary>
        /// Gets or sets the loss.
        /// </summary>
        /// <value>
        /// The loss.
        /// </value>
        [JsonProperty("loss")]
        public int Loss { get; set; }

        /// <summary>
        /// Gets or sets the draw.
        /// </summary>
        /// <value>
        /// The draw.
        /// </value>
        [JsonProperty("draw")]
        public int Draw { get; set; }

        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>
        /// The points.
        /// </value>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        [JsonProperty("form")]
        public object Form { get; set; }

        /// <summary>
        /// Gets or sets the link URL.
        /// </summary>
        /// <value>
        /// The link URL.
        /// </value>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Gets or sets the strength overall home.
        /// </summary>
        /// <value>
        /// The strength overall home.
        /// </value>
        [JsonProperty("strength_overall_home")]
        public int StrengthOverallHome { get; set; }

        /// <summary>
        /// Gets or sets the strength overall away.
        /// </summary>
        /// <value>
        /// The strength overall away.
        /// </value>
        [JsonProperty("strength_overall_away")]
        public int StrengthOverallAway { get; set; }

        /// <summary>
        /// Gets or sets the strength attack home.
        /// </summary>
        /// <value>
        /// The strength attack home.
        /// </value>
        [JsonProperty("strength_attack_home")]
        public int StrengthAttackHome { get; set; }

        /// <summary>
        /// Gets or sets the strength attack away.
        /// </summary>
        /// <value>
        /// The strength attack away.
        /// </value>
        [JsonProperty("strength_attack_away")]
        public int StrengthAttackAway { get; set; }

        /// <summary>
        /// Gets or sets the strength defence home.
        /// </summary>
        /// <value>
        /// The strength defence home.
        /// </value>
        [JsonProperty("strength_defence_home")]
        public int StrengthDefenceHome { get; set; }

        /// <summary>
        /// Gets or sets the strength defence away.
        /// </summary>
        /// <value>
        /// The strength defence away.
        /// </value>
        [JsonProperty("strength_defence_away")]
        public int StrengthDefenceAway { get; set; }

        /// <summary>
        /// Gets or sets the team division.
        /// </summary>
        /// <value>
        /// The team division.
        /// </value>
        [JsonProperty("team_division")]
        public int TeamDivision { get; set; }
    }
}
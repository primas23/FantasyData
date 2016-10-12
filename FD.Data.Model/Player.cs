// <copyright file="Player.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Player class
    /// </summary>
    public class Player
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
        /// Gets or sets the photo.
        /// </summary>
        /// <value>
        /// The photo.
        /// </value>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// Gets or sets the player`s web name.
        /// </summary>
        /// <value>
        /// The name of the web.
        /// </value>
        [JsonProperty("web_name")]
        public string WebName { get; set; }

        /// <summary>
        /// Gets or sets the team code.
        /// </summary>
        /// <value>
        /// The team code.
        /// </value>
        [JsonProperty("team_code")]
        public int TeamCode { get; set; }

        /// <summary>
        /// Gets or sets the status of the player indicating if he is available.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the code of the player.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the second.
        /// </summary>
        /// <value>
        /// The name of the second.
        /// </value>
        [JsonProperty("second_name")]
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or sets the squad number.
        /// </summary>
        /// <value>
        /// The squad number.
        /// </value>
        [JsonProperty("squad_number")]
        public int? SquadNumber { get; set; }

        /// <summary>
        /// Gets or sets the news.
        /// </summary>
        /// <value>
        /// The news.
        /// </value>
        [JsonProperty("news")]
        public string News { get; set; }

        /// <summary>
        /// Gets or sets the current cost of the player.
        /// </summary>
        /// <value>
        /// The now cost.
        /// </value>
        [JsonProperty("now_cost")]
        public int NowCost { get; set; }

        /// <summary>
        /// Gets or sets the chance of playing this round.
        /// </summary>
        /// <value>
        /// The chance of playing this round.
        /// </value>
        [JsonProperty("chance_of_playing_this_round")]
        public int? ChanceOfPlayingThisRound { get; set; }

        /// <summary>
        /// Gets or sets the chance of playing next round.
        /// </summary>
        /// <value>
        /// The chance of playing next round.
        /// </value>
        [JsonProperty("chance_of_playing_next_round")]
        public int? ChanceOfPlayingNextRound { get; set; }

        /// <summary>
        /// Gets or sets the value form.
        /// </summary>
        /// <value>
        /// The value form.
        /// </value>
        [JsonProperty("value_form")]
        public string ValueForm { get; set; }

        /// <summary>
        /// Gets or sets the value season.
        /// </summary>
        /// <value>
        /// The value season.
        /// </value>
        [JsonProperty("value_season")]
        public string ValueSeason { get; set; }

        /// <summary>
        /// Gets or sets the cost change start.
        /// </summary>
        /// <value>
        /// The cost change start.
        /// </value>
        [JsonProperty("cost_change_start")]
        public int CostChangeStart { get; set; }

        /// <summary>
        /// Gets or sets the cost change event.
        /// </summary>
        /// <value>
        /// The cost change event.
        /// </value>
        [JsonProperty("cost_change_event")]
        public int CostChangeEvent { get; set; }

        /// <summary>
        /// Gets or sets the cost change start fall.
        /// </summary>
        /// <value>
        /// The cost change start fall.
        /// </value>
        [JsonProperty("cost_change_start_fall")]
        public int CostChangeStartFall { get; set; }

        /// <summary>
        /// Gets or sets the cost change event fall.
        /// </summary>
        /// <value>
        /// The cost change event fall.
        /// </value>
        [JsonProperty("cost_change_event_fall")]
        public int CostChangeEventFall { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is in the dreamteam.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [in dreamteam]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("in_dreamteam")]
        public bool InDreamteam { get; set; }

        /// <summary>
        /// Gets or sets the number of appearances pf the player in the dreamteam.
        /// </summary>
        /// <value>
        /// The dreamteam count.
        /// </value>
        [JsonProperty("dreamteam_count")]
        public int DreamteamCount { get; set; }

        /// <summary>
        /// Gets or sets the selected by people percent.
        /// </summary>
        /// <value>
        /// The selected by percent.
        /// </value>
        [JsonProperty("selected_by_percent")]
        public string SelectedByPercent { get; set; }

        /// <summary>
        /// Gets or sets the current form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        [JsonProperty("form")]
        public string Form { get; set; }

        /// <summary>
        /// Gets or sets the transfers out.
        /// </summary>
        /// <value>
        /// The transfers out.
        /// </value>
        [JsonProperty("transfers_out")]
        public int TransfersOut { get; set; }

        /// <summary>
        /// Gets or sets the transfers in.
        /// </summary>
        /// <value>
        /// The transfers in.
        /// </value>
        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        /// <summary>
        /// Gets or sets the transfers out event.
        /// </summary>
        /// <value>
        /// The transfers out event.
        /// </value>
        [JsonProperty("transfers_out_event")]
        public int TransfersOutEvent { get; set; }

        /// <summary>
        /// Gets or sets the transfers in event.
        /// </summary>
        /// <value>
        /// The transfers in event.
        /// </value>
        [JsonProperty("transfers_in_event")]
        public int TransfersInEvent { get; set; }

        /// <summary>
        /// Gets or sets the loans in.
        /// </summary>
        /// <value>
        /// The loans in.
        /// </value>
        [JsonProperty("loans_in")]
        public int LoansIn { get; set; }

        /// <summary>
        /// Gets or sets the loans out.
        /// </summary>
        /// <value>
        /// The loans out.
        /// </value>
        [JsonProperty("loans_out")]
        public int LoansOut { get; set; }

        /// <summary>
        /// Gets or sets the loaned in.
        /// </summary>
        /// <value>
        /// The loaned in.
        /// </value>
        [JsonProperty("loaned_in")]
        public int LoanedIn { get; set; }

        /// <summary>
        /// Gets or sets the loaned out.
        /// </summary>
        /// <value>
        /// The loaned out.
        /// </value>
        [JsonProperty("loaned_out")]
        public int LoanedOut { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the event points.
        /// </summary>
        /// <value>
        /// The event points.
        /// </value>
        [JsonProperty("event_points")]
        public int EventPoints { get; set; }

        /// <summary>
        /// Gets or sets the points per game.
        /// </summary>
        /// <value>
        /// The points per game.
        /// </value>
        [JsonProperty("points_per_game")]
        public string PointsPerGame { get; set; }

        /// <summary>
        /// Gets or sets the ep this.
        /// </summary>
        /// <value>
        /// The ep this.
        /// </value>
        [JsonProperty("ep_this")]
        public string EpThis { get; set; }

        /// <summary>
        /// Gets or sets the ep next.
        /// </summary>
        /// <value>
        /// The ep next.
        /// </value>
        [JsonProperty("ep_next")]
        public string EpNext { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Player"/> is special.
        /// </summary>
        /// <value>
        ///   <c>true</c> if special; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("special")]
        public bool Special { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        /// Gets or sets the goals scored.
        /// </summary>
        /// <value>
        /// The goals scored.
        /// </value>
        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the assists.
        /// </summary>
        /// <value>
        /// The assists.
        /// </value>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Gets or sets the clean sheets.
        /// </summary>
        /// <value>
        /// The clean sheets.
        /// </value>
        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the goals conceded.
        /// </summary>
        /// <value>
        /// The goals conceded.
        /// </value>
        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        /// <summary>
        /// Gets or sets the own goals.
        /// </summary>
        /// <value>
        /// The own goals.
        /// </value>
        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the penalties saved.
        /// </summary>
        /// <value>
        /// The penalties saved.
        /// </value>
        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the penalties missed.
        /// </summary>
        /// <value>
        /// The penalties missed.
        /// </value>
        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the yellow cards.
        /// </summary>
        /// <value>
        /// The yellow cards.
        /// </value>
        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        /// <summary>
        /// Gets or sets the red cards.
        /// </summary>
        /// <value>
        /// The red cards.
        /// </value>
        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        /// <summary>
        /// Gets or sets the saves.
        /// </summary>
        /// <value>
        /// The saves.
        /// </value>
        [JsonProperty("saves")]
        public int Saves { get; set; }

        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the BPS.
        /// </summary>
        /// <value>
        /// The BPS.
        /// </value>
        [JsonProperty("bps")]
        public int Bps { get; set; }

        /// <summary>
        /// Gets or sets the influence.
        /// </summary>
        /// <value>
        /// The influence.
        /// </value>
        [JsonProperty("influence")]
        public string Influence { get; set; }

        /// <summary>
        /// Gets or sets the creativity.
        /// </summary>
        /// <value>
        /// The creativity.
        /// </value>
        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        /// <summary>
        /// Gets or sets the threat.
        /// </summary>
        /// <value>
        /// The threat.
        /// </value>
        [JsonProperty("threat")]
        public string Threat { get; set; }

        /// <summary>
        /// Gets or sets the index of the ict.
        /// </summary>
        /// <value>
        /// The index of the ict.
        /// </value>
        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the ea.
        /// </summary>
        /// <value>
        /// The index of the ea.
        /// </value>
        [JsonProperty("ea_index")]
        public int EaIndex { get; set; }

        /// <summary>
        /// Gets or sets the type of the element.
        /// </summary>
        /// <value>
        /// The type of the element.
        /// </value>
        [JsonProperty("element_type")]
        public int ElementType { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public int Team { get; set; }
    }
}
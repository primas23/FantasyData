namespace FD.Data.Common.Contracts
{
    public interface IPlayer : IIdentifier<int>
    {
        /// <summary>
        /// Gets or sets the photo.
        /// </summary>
        /// <value>
        /// The photo.
        /// </value>
        string Photo { get; set; }

        /// <summary>
        /// Gets or sets the player`s web name.
        /// </summary>
        /// <value>
        /// The name of the web.
        /// </value>
        string WebName { get; set; }

        /// <summary>
        /// Gets or sets the team code.
        /// </summary>
        /// <value>
        /// The team code.
        /// </value>
        int TeamCode { get; set; }

        /// <summary>
        /// Gets or sets the status of the player indicating if he is available.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        string Status { get; set; }

        /// <summary>
        /// Gets or sets the code of the player.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        int Code { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the second.
        /// </summary>
        /// <value>
        /// The name of the second.
        /// </value>
        string SecondName { get; set; }

        /// <summary>
        /// Gets or sets the squad number.
        /// </summary>
        /// <value>
        /// The squad number.
        /// </value>
        int? SquadNumber { get; set; }

        /// <summary>
        /// Gets or sets the news.
        /// </summary>
        /// <value>
        /// The news.
        /// </value>
        string News { get; set; }

        /// <summary>
        /// Gets or sets the current cost of the player.
        /// </summary>
        /// <value>
        /// The now cost.
        /// </value>
        int NowCost { get; set; }

        /// <summary>
        /// Gets or sets the chance of playing this round.
        /// </summary>
        /// <value>
        /// The chance of playing this round.
        /// </value>
        int? ChanceOfPlayingThisRound { get; set; }

        /// <summary>
        /// Gets or sets the chance of playing next round.
        /// </summary>
        /// <value>
        /// The chance of playing next round.
        /// </value>
        int? ChanceOfPlayingNextRound { get; set; }

        /// <summary>
        /// Gets or sets the value form.
        /// </summary>
        /// <value>
        /// The value form.
        /// </value>
        string ValueForm { get; set; }

        /// <summary>
        /// Gets or sets the value season.
        /// </summary>
        /// <value>
        /// The value season.
        /// </value>
        string ValueSeason { get; set; }

        /// <summary>
        /// Gets or sets the cost change start.
        /// </summary>
        /// <value>
        /// The cost change start.
        /// </value>
        int CostChangeStart { get; set; }

        /// <summary>
        /// Gets or sets the cost change event.
        /// </summary>
        /// <value>
        /// The cost change event.
        /// </value>
        int CostChangeEvent { get; set; }

        /// <summary>
        /// Gets or sets the cost change start fall.
        /// </summary>
        /// <value>
        /// The cost change start fall.
        /// </value>
        int CostChangeStartFall { get; set; }

        /// <summary>
        /// Gets or sets the cost change event fall.
        /// </summary>
        /// <value>
        /// The cost change event fall.
        /// </value>
        int CostChangeEventFall { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is in the dreamteam.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [in dreamteam]; otherwise, <c>false</c>.
        /// </value>
        bool InDreamteam { get; set; }

        /// <summary>
        /// Gets or sets the number of appearances pf the player in the dreamteam.
        /// </summary>
        /// <value>
        /// The dreamteam count.
        /// </value>
        int DreamteamCount { get; set; }

        /// <summary>
        /// Gets or sets the selected by people percent.
        /// </summary>
        /// <value>
        /// The selected by percent.
        /// </value>
        string SelectedByPercent { get; set; }

        /// <summary>
        /// Gets or sets the current form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        string Form { get; set; }

        /// <summary>
        /// Gets or sets the transfers out.
        /// </summary>
        /// <value>
        /// The transfers out.
        /// </value>
        int TransfersOut { get; set; }

        /// <summary>
        /// Gets or sets the transfers in.
        /// </summary>
        /// <value>
        /// The transfers in.
        /// </value>
        int TransfersIn { get; set; }

        /// <summary>
        /// Gets or sets the transfers out event.
        /// </summary>
        /// <value>
        /// The transfers out event.
        /// </value>
        int TransfersOutEvent { get; set; }

        /// <summary>
        /// Gets or sets the transfers in event.
        /// </summary>
        /// <value>
        /// The transfers in event.
        /// </value>
        int TransfersInEvent { get; set; }

        /// <summary>
        /// Gets or sets the loans in.
        /// </summary>
        /// <value>
        /// The loans in.
        /// </value>
        int LoansIn { get; set; }

        /// <summary>
        /// Gets or sets the loans out.
        /// </summary>
        /// <value>
        /// The loans out.
        /// </value>
        int LoansOut { get; set; }

        /// <summary>
        /// Gets or sets the loaned in.
        /// </summary>
        /// <value>
        /// The loaned in.
        /// </value>
        int LoanedIn { get; set; }

        /// <summary>
        /// Gets or sets the loaned out.
        /// </summary>
        /// <value>
        /// The loaned out.
        /// </value>
        int LoanedOut { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        int TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the event points.
        /// </summary>
        /// <value>
        /// The event points.
        /// </value>
        int EventPoints { get; set; }

        /// <summary>
        /// Gets or sets the points per game.
        /// </summary>
        /// <value>
        /// The points per game.
        /// </value>
        string PointsPerGame { get; set; }

        /// <summary>
        /// Gets or sets the ep this.
        /// </summary>
        /// <value>
        /// The ep this.
        /// </value>
        string EpThis { get; set; }

        /// <summary>
        /// Gets or sets the ep next.
        /// </summary>
        /// <value>
        /// The ep next.
        /// </value>
        string EpNext { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Player"/> is special.
        /// </summary>
        /// <value>
        ///   <c>true</c> if special; otherwise, <c>false</c>.
        /// </value>
        bool Special { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        int Minutes { get; set; }

        /// <summary>
        /// Gets or sets the goals scored.
        /// </summary>
        /// <value>
        /// The goals scored.
        /// </value>
        int GoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the assists.
        /// </summary>
        /// <value>
        /// The assists.
        /// </value>
        int Assists { get; set; }

        /// <summary>
        /// Gets or sets the clean sheets.
        /// </summary>
        /// <value>
        /// The clean sheets.
        /// </value>
        int CleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the goals conceded.
        /// </summary>
        /// <value>
        /// The goals conceded.
        /// </value>
        int GoalsConceded { get; set; }

        /// <summary>
        /// Gets or sets the own goals.
        /// </summary>
        /// <value>
        /// The own goals.
        /// </value>
        int OwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the penalties saved.
        /// </summary>
        /// <value>
        /// The penalties saved.
        /// </value>
        int PenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the penalties missed.
        /// </summary>
        /// <value>
        /// The penalties missed.
        /// </value>
        int PenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the yellow cards.
        /// </summary>
        /// <value>
        /// The yellow cards.
        /// </value>
        int YellowCards { get; set; }

        /// <summary>
        /// Gets or sets the red cards.
        /// </summary>
        /// <value>
        /// The red cards.
        /// </value>
        int RedCards { get; set; }

        /// <summary>
        /// Gets or sets the saves.
        /// </summary>
        /// <value>
        /// The saves.
        /// </value>
        int Saves { get; set; }

        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the BPS.
        /// </summary>
        /// <value>
        /// The BPS.
        /// </value>
        int Bps { get; set; }

        /// <summary>
        /// Gets or sets the influence.
        /// </summary>
        /// <value>
        /// The influence.
        /// </value>
        string Influence { get; set; }

        /// <summary>
        /// Gets or sets the creativity.
        /// </summary>
        /// <value>
        /// The creativity.
        /// </value>
        string Creativity { get; set; }

        /// <summary>
        /// Gets or sets the threat.
        /// </summary>
        /// <value>
        /// The threat.
        /// </value>
        string Threat { get; set; }

        /// <summary>
        /// Gets or sets the index of the ict.
        /// </summary>
        /// <value>
        /// The index of the ict.
        /// </value>
        string IctIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the ea.
        /// </summary>
        /// <value>
        /// The index of the ea.
        /// </value>
        int EaIndex { get; set; }

        /// <summary>
        /// Gets or sets the type of the element.
        /// </summary>
        /// <value>
        /// The type of the element.
        /// </value>
        int ElementType { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        int Team { get; set; }
    }
}
// <copyright file="Game.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FD.Data.Model
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The game class
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Gets or sets the index of the scoring ea.
        /// </summary>
        /// <value>
        /// The index of the scoring ea.
        /// </value>
        [JsonProperty("scoring_ea_index")]
        public int ScoringEaIndex { get; set; }

        /// <summary>
        /// Gets or sets the league prefix public.
        /// </summary>
        /// <value>
        /// The league prefix public.
        /// </value>
        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }

        /// <summary>
        /// Gets or sets the BPS tackles.
        /// </summary>
        /// <value>
        /// The BPS tackles.
        /// </value>
        [JsonProperty("bps_tackles")]
        public int BpsTackles { get; set; }

        /// <summary>
        /// Gets or sets the league H2H tiebreak.
        /// </summary>
        /// <value>
        /// The league H2H tiebreak.
        /// </value>
        [JsonProperty("league_h2h_tiebreak")]
        public string LeagueH2HTiebreak { get; set; }

        /// <summary>
        /// Gets or sets the scoring long play.
        /// </summary>
        /// <value>
        /// The scoring long play.
        /// </value>
        [JsonProperty("scoring_long_play")]
        public int ScoringLongPlay { get; set; }

        /// <summary>
        /// Gets or sets the BPS recoveries limit.
        /// </summary>
        /// <value>
        /// The BPS recoveries limit.
        /// </value>
        [JsonProperty("bps_recoveries_limit")]
        public int BpsRecoveriesLimit { get; set; }

        /// <summary>
        /// Gets or sets the facebook application identifier.
        /// </summary>
        /// <value>
        /// The facebook application identifier.
        /// </value>
        [JsonProperty("facebook_app_id")]
        public string FacebookAppId { get; set; }

        /// <summary>
        /// Gets or sets the BPS tackled.
        /// </summary>
        /// <value>
        /// The BPS tackled.
        /// </value>
        [JsonProperty("bps_tackled")]
        public int BpsTackled { get; set; }

        /// <summary>
        /// Gets or sets the BPS errors leading to goal.
        /// </summary>
        /// <value>
        /// The BPS errors leading to goal.
        /// </value>
        [JsonProperty("bps_errors_leading_to_goal")]
        public int BpsErrorsLeadingToGoal { get; set; }

        /// <summary>
        /// Gets or sets the BPS yellow cards.
        /// </summary>
        /// <value>
        /// The BPS yellow cards.
        /// </value>
        [JsonProperty("bps_yellow_cards")]
        public int BpsYellowCards { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [UI el hide currency qi].
        /// </summary>
        /// <value>
        /// <c>true</c> if [UI el hide currency qi]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("ui_el_hide_currency_qi")]
        public bool UiElHideCurrencyQi { get; set; }

        /// <summary>
        /// Gets or sets the scoring bonus.
        /// </summary>
        /// <value>
        /// The scoring bonus.
        /// </value>
        [JsonProperty("scoring_bonus")]
        public int ScoringBonus { get; set; }

        /// <summary>
        /// Gets or sets the transfers cost.
        /// </summary>
        /// <value>
        /// The transfers cost.
        /// </value>
        [JsonProperty("transfers_cost")]
        public int TransfersCost { get; set; }

        /// <summary>
        /// Gets or sets the default formation.
        /// </summary>
        /// <value>
        /// The default formation.
        /// </value>
        [JsonProperty("default_formation")]
        public IList<IList<int>> DefaultFormation { get; set; }

        /// <summary>
        /// Gets or sets the BPS long play.
        /// </summary>
        /// <value>
        /// The BPS long play.
        /// </value>
        [JsonProperty("bps_long_play")]
        public int BpsLongPlay { get; set; }

        /// <summary>
        /// Gets or sets the BPS long play limit.
        /// </summary>
        /// <value>
        /// The BPS long play limit.
        /// </value>
        [JsonProperty("bps_long_play_limit")]
        public int BpsLongPlayLimit { get; set; }

        /// <summary>
        /// Gets or sets the scoring assists.
        /// </summary>
        /// <value>
        /// The scoring assists.
        /// </value>
        [JsonProperty("scoring_assists")]
        public int ScoringAssists { get; set; }

        /// <summary>
        /// Gets or sets the scoring long play limit.
        /// </summary>
        /// <value>
        /// The scoring long play limit.
        /// </value>
        [JsonProperty("scoring_long_play_limit")]
        public int ScoringLongPlayLimit { get; set; }

        /// <summary>
        /// Gets or sets the fifa league identifier.
        /// </summary>
        /// <value>
        /// The fifa league identifier.
        /// </value>
        [JsonProperty("fifa_league_id")]
        public int FifaLeagueId { get; set; }

        /// <summary>
        /// Gets or sets the league size classic maximum.
        /// </summary>
        /// <value>
        /// The league size classic maximum.
        /// </value>
        [JsonProperty("league_size_classic_max")]
        public int LeagueSizeClassicMax { get; set; }

        /// <summary>
        /// Gets or sets the scoring red cards.
        /// </summary>
        /// <value>
        /// The scoring red cards.
        /// </value>
        [JsonProperty("scoring_red_cards")]
        public int ScoringRedCards { get; set; }

        /// <summary>
        /// Gets or sets the scoring creativity.
        /// </summary>
        /// <value>
        /// The scoring creativity.
        /// </value>
        [JsonProperty("scoring_creativity")]
        public int ScoringCreativity { get; set; }

        /// <summary>
        /// Gets or sets the game timezone.
        /// </summary>
        /// <value>
        /// The game timezone.
        /// </value>
        [JsonProperty("game_timezone")]
        public string GameTimezone { get; set; }

        /// <summary>
        /// Gets or sets the static game URL.
        /// </summary>
        /// <value>
        /// The static game URL.
        /// </value>
        [JsonProperty("static_game_url")]
        public string StaticGameUrl { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>
        /// The currency symbol.
        /// </value>
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the BPS target missed.
        /// </summary>
        /// <value>
        /// The BPS target missed.
        /// </value>
        [JsonProperty("bps_target_missed")]
        public int BpsTargetMissed { get; set; }

        /// <summary>
        /// Gets or sets the BPS penalties saved.
        /// </summary>
        /// <value>
        /// The BPS penalties saved.
        /// </value>
        [JsonProperty("bps_penalties_saved")]
        public int BpsPenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the support email address.
        /// </summary>
        /// <value>
        /// The support email address.
        /// </value>
        [JsonProperty("support_email_address")]
        public string SupportEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the cup start event identifier.
        /// </summary>
        /// <value>
        /// The cup start event identifier.
        /// </value>
        [JsonProperty("cup_start_event_id")]
        public int CupStartEventId { get; set; }

        /// <summary>
        /// Gets or sets the scoring penalties saved.
        /// </summary>
        /// <value>
        /// The scoring penalties saved.
        /// </value>
        [JsonProperty("scoring_penalties_saved")]
        public int ScoringPenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the scoring threat.
        /// </summary>
        /// <value>
        /// The scoring threat.
        /// </value>
        [JsonProperty("scoring_threat")]
        public int ScoringThreat { get; set; }

        /// <summary>
        /// Gets or sets the scoring saves.
        /// </summary>
        /// <value>
        /// The scoring saves.
        /// </value>
        [JsonProperty("scoring_saves")]
        public int ScoringSaves { get; set; }

        /// <summary>
        /// Gets or sets the league join private maximum.
        /// </summary>
        /// <value>
        /// The league join private maximum.
        /// </value>
        [JsonProperty("league_join_private_max")]
        public int LeagueJoinPrivateMax { get; set; }

        /// <summary>
        /// Gets or sets the scoring short play.
        /// </summary>
        /// <value>
        /// The scoring short play.
        /// </value>
        [JsonProperty("scoring_short_play")]
        public int ScoringShortPlay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [system use event live API].
        /// </summary>
        /// <value>
        /// <c>true</c> if [system use event live API]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("sys_use_event_live_api")]
        public bool SysUseEventLiveApi { get; set; }

        /// <summary>
        /// Gets or sets the scoring concede limit.
        /// </summary>
        /// <value>
        /// The scoring concede limit.
        /// </value>
        [JsonProperty("scoring_concede_limit")]
        public int ScoringConcedeLimit { get; set; }

        /// <summary>
        /// Gets or sets the BPS key passes.
        /// </summary>
        /// <value>
        /// The BPS key passes.
        /// </value>
        [JsonProperty("bps_key_passes")]
        public int BpsKeyPasses { get; set; }

        /// <summary>
        /// Gets or sets the BPS clearances blocks interceptions.
        /// </summary>
        /// <value>
        /// The BPS clearances blocks interceptions.
        /// </value>
        [JsonProperty("bps_clearances_blocks_interceptions")]
        public int BpsClearancesBlocksInterceptions { get; set; }

        /// <summary>
        /// Gets or sets the BPS pass percentage90.
        /// </summary>
        /// <value>
        /// The BPS pass percentage90.
        /// </value>
        [JsonProperty("bps_pass_percentage_90")]
        public int BpsPassPercentage90 { get; set; }

        /// <summary>
        /// Gets or sets the BPS big chances missed.
        /// </summary>
        /// <value>
        /// The BPS big chances missed.
        /// </value>
        [JsonProperty("bps_big_chances_missed")]
        public int BpsBigChancesMissed { get; set; }

        /// <summary>
        /// Gets or sets the league maximum ko rounds H2H.
        /// </summary>
        /// <value>
        /// The league maximum ko rounds H2H.
        /// </value>
        [JsonProperty("league_max_ko_rounds_h2h")]
        public int LeagueMaxKoRoundsH2H { get; set; }

        /// <summary>
        /// Gets or sets the BPS open play crosses.
        /// </summary>
        /// <value>
        /// The BPS open play crosses.
        /// </value>
        [JsonProperty("bps_open_play_crosses")]
        public int BpsOpenPlayCrosses { get; set; }

        /// <summary>
        /// Gets or sets the league points h2 h win.
        /// </summary>
        /// <value>
        /// The league points h2 h win.
        /// </value>
        [JsonProperty("league_points_h2h_win")]
        public int LeaguePointsH2HWin { get; set; }

        /// <summary>
        /// Gets or sets the BPS saves.
        /// </summary>
        /// <value>
        /// The BPS saves.
        /// </value>
        [JsonProperty("bps_saves")]
        public int BpsSaves { get; set; }

        /// <summary>
        /// Gets or sets the BPS cbi limit.
        /// </summary>
        /// <value>
        /// The BPS cbi limit.
        /// </value>
        [JsonProperty("bps_cbi_limit")]
        public int BpsCbiLimit { get; set; }

        /// <summary>
        /// Gets or sets the league size h2 h maximum.
        /// </summary>
        /// <value>
        /// The league size h2 h maximum.
        /// </value>
        [JsonProperty("league_size_h2h_max")]
        public int LeagueSizeH2HMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [system vice captain enabled].
        /// </summary>
        /// <value>
        /// <c>true</c> if [system vice captain enabled]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }

        /// <summary>
        /// Gets or sets the squad squadplay.
        /// </summary>
        /// <value>
        /// The squad squadplay.
        /// </value>
        [JsonProperty("squad_squadplay")]
        public int SquadSquadplay { get; set; }

        /// <summary>
        /// Gets or sets the BPS fouls.
        /// </summary>
        /// <value>
        /// The BPS fouls.
        /// </value>
        [JsonProperty("bps_fouls")]
        public int BpsFouls { get; set; }

        /// <summary>
        /// Gets or sets the squad squadsize.
        /// </summary>
        /// <value>
        /// The squad squadsize.
        /// </value>
        [JsonProperty("squad_squadsize")]
        public int SquadSquadsize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [UI selection short team names].
        /// </summary>
        /// <value>
        /// <c>true</c> if [UI selection short team names]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("ui_selection_short_team_names")]
        public bool UiSelectionShortTeamNames { get; set; }

        /// <summary>
        /// Gets or sets the transfers sell on fee.
        /// </summary>
        /// <value>
        /// The transfers sell on fee.
        /// </value>
        [JsonProperty("transfers_sell_on_fee")]
        public double TransfersSellOnFee { get; set; }

        /// <summary>
        /// Gets or sets the type of the transfers.
        /// </summary>
        /// <value>
        /// The type of the transfers.
        /// </value>
        [JsonProperty("transfers_type")]
        public string TransfersType { get; set; }

        /// <summary>
        /// Gets or sets the index of the scoring ict.
        /// </summary>
        /// <value>
        /// The index of the scoring ict.
        /// </value>
        [JsonProperty("scoring_ict_index")]
        public int ScoringIctIndex { get; set; }

        /// <summary>
        /// Gets or sets the BPS pass percentage80.
        /// </summary>
        /// <value>
        /// The BPS pass percentage80.
        /// </value>
        [JsonProperty("bps_pass_percentage_80")]
        public int BpsPassPercentage80 { get; set; }

        /// <summary>
        /// Gets or sets the BPS own goals.
        /// </summary>
        /// <value>
        /// The BPS own goals.
        /// </value>
        [JsonProperty("bps_own_goals")]
        public int BpsOwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the scoring yellow cards.
        /// </summary>
        /// <value>
        /// The scoring yellow cards.
        /// </value>
        [JsonProperty("scoring_yellow_cards")]
        public int ScoringYellowCards { get; set; }

        /// <summary>
        /// Gets or sets the BPS pass percentage70.
        /// </summary>
        /// <value>
        /// The BPS pass percentage70.
        /// </value>
        [JsonProperty("bps_pass_percentage_70")]
        public int BpsPassPercentage70 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [UI show home away].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [UI show home away]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("ui_show_home_away")]
        public bool UiShowHomeAway { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [UI el hide currency sy].
        /// </summary>
        /// <value>
        /// <c>true</c> if [UI el hide currency sy]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("ui_el_hide_currency_sy")]
        public bool UiElHideCurrencySy { get; set; }

        /// <summary>
        /// Gets or sets the BPS assists.
        /// </summary>
        /// <value>
        /// The BPS assists.
        /// </value>
        [JsonProperty("bps_assists")]
        public int BpsAssists { get; set; }

        /// <summary>
        /// Gets or sets the squad team limit.
        /// </summary>
        /// <value>
        /// The squad team limit.
        /// </value>
        [JsonProperty("squad_team_limit")]
        public int SquadTeamLimit { get; set; }

        /// <summary>
        /// Gets or sets the league points H2H draw.
        /// </summary>
        /// <value>
        /// The league points H2H draw.
        /// </value>
        [JsonProperty("league_points_h2h_draw")]
        public int LeaguePointsH2HDraw { get; set; }

        /// <summary>
        /// Gets or sets the transfers limit.
        /// </summary>
        /// <value>
        /// The transfers limit.
        /// </value>
        [JsonProperty("transfers_limit")]
        public int TransfersLimit { get; set; }

        /// <summary>
        /// Gets or sets the BPS dribbles.
        /// </summary>
        /// <value>
        /// The BPS dribbles.
        /// </value>
        [JsonProperty("bps_dribbles")]
        public int BpsDribbles { get; set; }

        /// <summary>
        /// Gets or sets the perform league identifier.
        /// </summary>
        /// <value>
        /// The perform league identifier.
        /// </value>
        [JsonProperty("perform_league_id")]
        public int PerformLeagueId { get; set; }

        /// <summary>
        /// Gets or sets the BPS offside.
        /// </summary>
        /// <value>
        /// The BPS offside.
        /// </value>
        [JsonProperty("bps_offside")]
        public int BpsOffside { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [system CDN cache enabled].
        /// </summary>
        /// <value>
        /// <c>true</c> if [system CDN cache enabled]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("sys_cdn_cache_enabled")]
        public bool SysCdnCacheEnabled { get; set; }

        /// <summary>
        /// Gets or sets the currency multiplier.
        /// </summary>
        /// <value>
        /// The currency multiplier.
        /// </value>
        [JsonProperty("currency_multiplier")]
        public int CurrencyMultiplier { get; set; }

        /// <summary>
        /// Gets or sets the BPS red cards.
        /// </summary>
        /// <value>
        /// The BPS red cards.
        /// </value>
        [JsonProperty("bps_red_cards")]
        public int BpsRedCards { get; set; }

        /// <summary>
        /// Gets or sets the BPS winning goals.
        /// </summary>
        /// <value>
        /// The BPS winning goals.
        /// </value>
        [JsonProperty("bps_winning_goals")]
        public int BpsWinningGoals { get; set; }

        /// <summary>
        /// Gets or sets the league join public maximum.
        /// </summary>
        /// <value>
        /// The league join public maximum.
        /// </value>
        [JsonProperty("league_join_public_max")]
        public int LeagueJoinPublicMax { get; set; }

        /// <summary>
        /// Gets or sets the formations.
        /// </summary>
        /// <value>
        /// The formations.
        /// </value>
        [JsonProperty("formations")]
        public Formations Formations { get; set; }

        /// <summary>
        /// Gets or sets the league points H2H lose.
        /// </summary>
        /// <value>
        /// The league points H2H lose.
        /// </value>
        [JsonProperty("league_points_h2h_lose")]
        public int LeaguePointsH2HLose { get; set; }

        /// <summary>
        /// Gets or sets the currency decimal places.
        /// </summary>
        /// <value>
        /// The currency decimal places.
        /// </value>
        [JsonProperty("currency_decimal_places")]
        public int CurrencyDecimalPlaces { get; set; }

        /// <summary>
        /// Gets or sets the BPS errors leading to goal attempt.
        /// </summary>
        /// <value>
        /// The BPS errors leading to goal attempt.
        /// </value>
        [JsonProperty("bps_errors_leading_to_goal_attempt")]
        public int BpsErrorsLeadingToGoalAttempt { get; set; }

        /// <summary>
        /// Gets or sets the UI selection price gap.
        /// </summary>
        /// <value>
        /// The UI selection price gap.
        /// </value>
        [JsonProperty("ui_selection_price_gap")]
        public int UiSelectionPriceGap { get; set; }

        /// <summary>
        /// Gets or sets the BPS big chances created.
        /// </summary>
        /// <value>
        /// The BPS big chances created.
        /// </value>
        [JsonProperty("bps_big_chances_created")]
        public int BpsBigChancesCreated { get; set; }

        /// <summary>
        /// Gets or sets the UI selection player limit.
        /// </summary>
        /// <value>
        /// The UI selection player limit.
        /// </value>
        [JsonProperty("ui_selection_player_limit")]
        public int UiSelectionPlayerLimit { get; set; }

        /// <summary>
        /// Gets or sets the BPS attempted passes limit.
        /// </summary>
        /// <value>
        /// The BPS attempted passes limit.
        /// </value>
        [JsonProperty("bps_attempted_passes_limit")]
        public int BpsAttemptedPassesLimit { get; set; }

        /// <summary>
        /// Gets or sets the scoring penalties missed.
        /// </summary>
        /// <value>
        /// The scoring penalties missed.
        /// </value>
        [JsonProperty("scoring_penalties_missed")]
        public int ScoringPenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the photo base URL.
        /// </summary>
        /// <value>
        /// The photo base URL.
        /// </value>
        [JsonProperty("photo_base_url")]
        public string PhotoBaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the scoring BPS.
        /// </summary>
        /// <value>
        /// The scoring BPS.
        /// </value>
        [JsonProperty("scoring_bps")]
        public int ScoringBps { get; set; }

        /// <summary>
        /// Gets or sets the scoring influence.
        /// </summary>
        /// <value>
        /// The scoring influence.
        /// </value>
        [JsonProperty("scoring_influence")]
        public int ScoringInfluence { get; set; }

        /// <summary>
        /// Gets or sets the BPS penalties conceded.
        /// </summary>
        /// <value>
        /// The BPS penalties conceded.
        /// </value>
        [JsonProperty("bps_penalties_conceded")]
        public int BpsPenaltiesConceded { get; set; }

        /// <summary>
        /// Gets or sets the scoring own goals.
        /// </summary>
        /// <value>
        /// The scoring own goals.
        /// </value>
        [JsonProperty("scoring_own_goals")]
        public int ScoringOwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the squad total spend.
        /// </summary>
        /// <value>
        /// The squad total spend.
        /// </value>
        [JsonProperty("squad_total_spend")]
        public int SquadTotalSpend { get; set; }

        /// <summary>
        /// Gets or sets the BPS short play.
        /// </summary>
        /// <value>
        /// The BPS short play.
        /// </value>
        [JsonProperty("bps_short_play")]
        public int BpsShortPlay { get; set; }

        /// <summary>
        /// Gets or sets the UI element wrap.
        /// </summary>
        /// <value>
        /// The UI element wrap.
        /// </value>
        [JsonProperty("ui_element_wrap")]
        public int UiElementWrap { get; set; }

        /// <summary>
        /// Gets or sets the BPS recoveries.
        /// </summary>
        /// <value>
        /// The BPS recoveries.
        /// </value>
        [JsonProperty("bps_recoveries")]
        public int BpsRecoveries { get; set; }

        /// <summary>
        /// Gets or sets the BPS penalties missed.
        /// </summary>
        /// <value>
        /// The BPS penalties missed.
        /// </value>
        [JsonProperty("bps_penalties_missed")]
        public int BpsPenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the scoring saves limit.
        /// </summary>
        /// <value>
        /// The scoring saves limit.
        /// </value>
        [JsonProperty("scoring_saves_limit")]
        public int ScoringSavesLimit { get; set; }
    }
}
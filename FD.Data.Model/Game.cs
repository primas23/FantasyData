using System.Collections.Generic;
using Newtonsoft.Json;

namespace FD.Data.Model
{
    public class Game
    {

        [JsonProperty("scoring_ea_index")]
        public int ScoringEaIndex { get; set; }

        [JsonProperty("league_prefix_public")]
        public string LeaguePrefixPublic { get; set; }

        [JsonProperty("bps_tackles")]
        public int BpsTackles { get; set; }

        [JsonProperty("league_h2h_tiebreak")]
        public string LeagueH2hTiebreak { get; set; }

        [JsonProperty("scoring_long_play")]
        public int ScoringLongPlay { get; set; }

        [JsonProperty("bps_recoveries_limit")]
        public int BpsRecoveriesLimit { get; set; }

        [JsonProperty("facebook_app_id")]
        public string FacebookAppId { get; set; }

        [JsonProperty("bps_tackled")]
        public int BpsTackled { get; set; }

        [JsonProperty("bps_errors_leading_to_goal")]
        public int BpsErrorsLeadingToGoal { get; set; }

        [JsonProperty("bps_yellow_cards")]
        public int BpsYellowCards { get; set; }

        [JsonProperty("ui_el_hide_currency_qi")]
        public bool UiElHideCurrencyQi { get; set; }

        [JsonProperty("scoring_bonus")]
        public int ScoringBonus { get; set; }

        [JsonProperty("transfers_cost")]
        public int TransfersCost { get; set; }

        [JsonProperty("default_formation")]
        public IList<IList<int>> DefaultFormation { get; set; }

        [JsonProperty("bps_long_play")]
        public int BpsLongPlay { get; set; }

        [JsonProperty("bps_long_play_limit")]
        public int BpsLongPlayLimit { get; set; }

        [JsonProperty("scoring_assists")]
        public int ScoringAssists { get; set; }

        [JsonProperty("scoring_long_play_limit")]
        public int ScoringLongPlayLimit { get; set; }

        [JsonProperty("fifa_league_id")]
        public int FifaLeagueId { get; set; }

        [JsonProperty("league_size_classic_max")]
        public int LeagueSizeClassicMax { get; set; }

        [JsonProperty("scoring_red_cards")]
        public int ScoringRedCards { get; set; }

        [JsonProperty("scoring_creativity")]
        public int ScoringCreativity { get; set; }

        [JsonProperty("game_timezone")]
        public string GameTimezone { get; set; }

        [JsonProperty("static_game_url")]
        public string StaticGameUrl { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("bps_target_missed")]
        public int BpsTargetMissed { get; set; }

        [JsonProperty("bps_penalties_saved")]
        public int BpsPenaltiesSaved { get; set; }

        [JsonProperty("support_email_address")]
        public string SupportEmailAddress { get; set; }

        [JsonProperty("cup_start_event_id")]
        public int CupStartEventId { get; set; }

        [JsonProperty("scoring_penalties_saved")]
        public int ScoringPenaltiesSaved { get; set; }

        [JsonProperty("scoring_threat")]
        public int ScoringThreat { get; set; }

        [JsonProperty("scoring_saves")]
        public int ScoringSaves { get; set; }

        [JsonProperty("league_join_private_max")]
        public int LeagueJoinPrivateMax { get; set; }

        [JsonProperty("scoring_short_play")]
        public int ScoringShortPlay { get; set; }

        [JsonProperty("sys_use_event_live_api")]
        public bool SysUseEventLiveApi { get; set; }

        [JsonProperty("scoring_concede_limit")]
        public int ScoringConcedeLimit { get; set; }

        [JsonProperty("bps_key_passes")]
        public int BpsKeyPasses { get; set; }

        [JsonProperty("bps_clearances_blocks_interceptions")]
        public int BpsClearancesBlocksInterceptions { get; set; }

        [JsonProperty("bps_pass_percentage_90")]
        public int BpsPassPercentage90 { get; set; }

        [JsonProperty("bps_big_chances_missed")]
        public int BpsBigChancesMissed { get; set; }

        [JsonProperty("league_max_ko_rounds_h2h")]
        public int LeagueMaxKoRoundsH2h { get; set; }

        [JsonProperty("bps_open_play_crosses")]
        public int BpsOpenPlayCrosses { get; set; }

        [JsonProperty("league_points_h2h_win")]
        public int LeaguePointsH2hWin { get; set; }

        [JsonProperty("bps_saves")]
        public int BpsSaves { get; set; }

        [JsonProperty("bps_cbi_limit")]
        public int BpsCbiLimit { get; set; }

        [JsonProperty("league_size_h2h_max")]
        public int LeagueSizeH2hMax { get; set; }

        [JsonProperty("sys_vice_captain_enabled")]
        public bool SysViceCaptainEnabled { get; set; }

        [JsonProperty("squad_squadplay")]
        public int SquadSquadplay { get; set; }

        [JsonProperty("bps_fouls")]
        public int BpsFouls { get; set; }

        [JsonProperty("squad_squadsize")]
        public int SquadSquadsize { get; set; }

        [JsonProperty("ui_selection_short_team_names")]
        public bool UiSelectionShortTeamNames { get; set; }

        [JsonProperty("transfers_sell_on_fee")]
        public double TransfersSellOnFee { get; set; }

        [JsonProperty("transfers_type")]
        public string TransfersType { get; set; }

        [JsonProperty("scoring_ict_index")]
        public int ScoringIctIndex { get; set; }

        [JsonProperty("bps_pass_percentage_80")]
        public int BpsPassPercentage80 { get; set; }

        [JsonProperty("bps_own_goals")]
        public int BpsOwnGoals { get; set; }

        [JsonProperty("scoring_yellow_cards")]
        public int ScoringYellowCards { get; set; }

        [JsonProperty("bps_pass_percentage_70")]
        public int BpsPassPercentage70 { get; set; }

        [JsonProperty("ui_show_home_away")]
        public bool UiShowHomeAway { get; set; }

        [JsonProperty("ui_el_hide_currency_sy")]
        public bool UiElHideCurrencySy { get; set; }

        [JsonProperty("bps_assists")]
        public int BpsAssists { get; set; }

        [JsonProperty("squad_team_limit")]
        public int SquadTeamLimit { get; set; }

        [JsonProperty("league_points_h2h_draw")]
        public int LeaguePointsH2hDraw { get; set; }

        [JsonProperty("transfers_limit")]
        public int TransfersLimit { get; set; }

        [JsonProperty("bps_dribbles")]
        public int BpsDribbles { get; set; }

        [JsonProperty("perform_league_id")]
        public int PerformLeagueId { get; set; }

        [JsonProperty("bps_offside")]
        public int BpsOffside { get; set; }

        [JsonProperty("sys_cdn_cache_enabled")]
        public bool SysCdnCacheEnabled { get; set; }

        [JsonProperty("currency_multiplier")]
        public int CurrencyMultiplier { get; set; }

        [JsonProperty("bps_red_cards")]
        public int BpsRedCards { get; set; }

        [JsonProperty("bps_winning_goals")]
        public int BpsWinningGoals { get; set; }

        [JsonProperty("league_join_public_max")]
        public int LeagueJoinPublicMax { get; set; }

        [JsonProperty("formations")]
        public Formations Formations { get; set; }

        [JsonProperty("league_points_h2h_lose")]
        public int LeaguePointsH2hLose { get; set; }

        [JsonProperty("currency_decimal_places")]
        public int CurrencyDecimalPlaces { get; set; }

        [JsonProperty("bps_errors_leading_to_goal_attempt")]
        public int BpsErrorsLeadingToGoalAttempt { get; set; }

        [JsonProperty("ui_selection_price_gap")]
        public int UiSelectionPriceGap { get; set; }

        [JsonProperty("bps_big_chances_created")]
        public int BpsBigChancesCreated { get; set; }

        [JsonProperty("ui_selection_player_limit")]
        public int UiSelectionPlayerLimit { get; set; }

        [JsonProperty("bps_attempted_passes_limit")]
        public int BpsAttemptedPassesLimit { get; set; }

        [JsonProperty("scoring_penalties_missed")]
        public int ScoringPenaltiesMissed { get; set; }

        [JsonProperty("photo_base_url")]
        public string PhotoBaseUrl { get; set; }

        [JsonProperty("scoring_bps")]
        public int ScoringBps { get; set; }

        [JsonProperty("scoring_influence")]
        public int ScoringInfluence { get; set; }

        [JsonProperty("bps_penalties_conceded")]
        public int BpsPenaltiesConceded { get; set; }

        [JsonProperty("scoring_own_goals")]
        public int ScoringOwnGoals { get; set; }

        [JsonProperty("squad_total_spend")]
        public int SquadTotalSpend { get; set; }

        [JsonProperty("bps_short_play")]
        public int BpsShortPlay { get; set; }

        [JsonProperty("ui_element_wrap")]
        public int UiElementWrap { get; set; }

        [JsonProperty("bps_recoveries")]
        public int BpsRecoveries { get; set; }

        [JsonProperty("bps_penalties_missed")]
        public int BpsPenaltiesMissed { get; set; }

        [JsonProperty("scoring_saves_limit")]
        public int ScoringSavesLimit { get; set; }
    }
}
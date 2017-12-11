using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fifa.Models
{
    public class MatchDetail
    {
        [JsonProperty("c_Date")]
        public DateTime Date { get; set; }
        [JsonProperty("d_Date")]
        public long DateLong { get; set; }
        [JsonProperty("b_DateUnknown")]
        public bool DateUnknown { get; set; }
        [JsonProperty("b_TimeUnknown")]
        public bool TimeUnknown { get; set; }
        [JsonProperty("d_CurrentPeriodStartTime")]
        public object CurrentPeriodStartTime { get; set; }
        [JsonProperty("c_MatchEndTime")]
        public DateTime MatchEndTime { get; set; }
        [JsonProperty("d_MatchEndTime")]
        public long MatchEndTimeLong { get; set; }
        [JsonProperty("c_Score")]
        public string Score { get; set; }
        [JsonProperty("n_HomeGoals")]
        public int HomeGoals { get; set; }
        [JsonProperty("n_AwayGoals")]
        public int AwayGoals { get; set; }
        [JsonProperty("n_HomeGoalsHalftime")]
        public int HomeGoalsHalftime { get; set; }
        [JsonProperty("n_AwayGoalsHalftime")]
        public int AwayGoalsHalftime { get; set; }
        [JsonProperty("n_HomeGoals90mins")]
        public object HomeGoals90mins { get; set; }
        [JsonProperty("n_AwayGoals90mins")]
        public object AwayGoals90mins { get; set; }
        [JsonProperty("n_HomeGoals105mins")]
        public object HomeGoals105mins { get; set; }
        [JsonProperty("n_AwayGoals105mins")]
        public object AwayGoals105mins { get; set; }
        [JsonProperty("n_HomeGoalsShootout")]
        public object HomeGoalsShootout { get; set; }
        [JsonProperty("n_AwayGoalsShootout")]
        public object AwayGoalsShootout { get; set; }
        [JsonProperty("c_MatchStatusShort")]
        public string MatchStatusShort { get; set; }
        [JsonProperty("b_Started")]
        public bool Started { get; set; }
        [JsonProperty("b_Live")]
        public bool Live { get; set; }
        [JsonProperty("b_Finished")]
        public bool Finished { get; set; }
        [JsonProperty("b_Awarded")]
        public bool Awarded { get; set; }
        [JsonProperty("b_Abandoned")]
        public bool Abandoned { get; set; }
        [JsonProperty("b_Suspended")]
        public bool Suspended { get; set; }
        [JsonProperty("b_Postponed")]
        public bool Postponed { get; set; }
        [JsonProperty("b_RescheduledToBeResumed")]
        public bool RescheduledToBeResumed { get; set; }
        [JsonProperty("c_Stadium")]
        public string Stadium { get; set; }
        [JsonProperty("c_City")]
        public string City { get; set; }
        [JsonProperty("c_CountryShort")]
        public string CountryShort { get; set; }
        [JsonProperty("n_Spectators")]
        public int Spectators { get; set; }
        [JsonProperty("b_DataEntryLiveScore")]
        public bool DataEntryLiveScore { get; set; }
        [JsonProperty("b_DataEntryLiveGoal")]
        public bool DataEntryLiveGoal { get; set; }
        [JsonProperty("b_DataEntryLiveLineup")]
        public bool DataEntryLiveLineup { get; set; }
        [JsonProperty("n_InfostradaID")]
        public int InfostradaID { get; set; }
        [JsonProperty("n_MatchID")]
        public int MatchID { get; set; }
        [JsonProperty("c_CompetitionType")]
        public string CompetitionType { get; set; }
        [JsonProperty("n_CompetitionID")]
        public int CompetitionID { get; set; }
        [JsonProperty("n_FifaEdition")]
        public int FifaEdition { get; set; }
        [JsonProperty("c_Competition_en")]
        public string CompetitionEn { get; set; }
        [JsonProperty("c_Source")]
        public string Source { get; set; }
        [JsonProperty("c_Phase_en")]
        public object PhaseEn { get; set; }
        [JsonProperty("c_ShareURL")]
        public string ShareURL { get; set; }
        [JsonProperty("b_Current")]
        public bool Current { get; set; }
        [JsonProperty("b_ShowComments")]
        public bool ShowComments { get; set; }
        [JsonProperty("b_Lineup")]
        public bool Lineup { get; set; }
        [JsonProperty("b_Delayed")]
        public bool Delayed { get; set; }
        [JsonProperty("n_HomeTeamID")]
        public int HomeTeamID { get; set; }
        [JsonProperty("c_HomeTeam_en")]
        public string HomeTeamEn { get; set; }
        [JsonProperty("c_HomeLogoImage")]
        public string HomeLogoImage { get; set; }
        [JsonProperty("c_HomeNatioShort")]
        public string HomeNatioShort { get; set; }
        [JsonProperty("c_HomeType")]
        public string HomeType { get; set; }
        [JsonProperty("n_AwayTeamID")]
        public int AwayTeamID { get; set; }
        [JsonProperty("c_AwayTeam_en")]
        public string AwayTeamEn { get; set; }
        [JsonProperty("c_AwayLogoImage")]
        public string AwayLogoImage { get; set; }
        [JsonProperty("c_AwayNatioShort")]
        public string AwayNatioShort { get; set; }
        [JsonProperty("c_AwayType")]
        public string AwayType { get; set; }
        [JsonProperty("c_Minute")]
        public object Minute { get; set; }
        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }
        [JsonProperty("homeLineup")]
        public List<PersonInfo> HomeLineup { get; set; }
        [JsonProperty("homeSubs")]
        public List<PersonInfo> HomeSubs { get; set; }
        [JsonProperty("homeCoach")]
        public PersonInfo HomeCoach { get; set; }
        [JsonProperty("awayLineup")]
        public List<PersonInfo> AwayLineup { get; set; }
        [JsonProperty("awaySubs")]
        public List<PersonInfo> AwaySubs { get; set; }
        [JsonProperty("awayCoach")]
        public PersonInfo AwayCoach { get; set; }
        [JsonProperty("officials")]
        public List<PersonInfo> Officials { get; set; }
    }
}
using Newtonsoft.Json;

namespace Fifa.Models
{
    public class StandingDetail
    {
        [JsonProperty("n_TeamID")]
        public int TeamId { get; set; }
        [JsonProperty("c_LogoImage")]
        public string LogoImage { get; set; }
        [JsonProperty("c_TeamNatioShort")]
        public string TeamNatioShort { get; set; }
        [JsonProperty("c_Type")]
        public string Type { get; set; }
        [JsonProperty("c_Team_en")]
        public string TeamEn { get; set; }
        [JsonProperty("c_Rank")]
        public string Rank { get; set; }
        [JsonProperty("n_Matches")]
        public int Matches { get; set; }
        [JsonProperty("n_MatchesWon")]
        public int MatchesWon { get; set; }
        [JsonProperty("n_MatchesDrawn")]
        public int MatchesDrawn { get; set; }
        [JsonProperty("n_MatchesLost")]
        public int MatchesLost { get; set; }
        [JsonProperty("n_Points")]
        public int Points { get; set; }
        [JsonProperty("n_GoalsFor")]
        public int GoalsFor { get; set; }
        [JsonProperty("n_GoalsAgainst")]
        public int GoalsAgainst { get; set; }
        [JsonProperty("c_QualificationColor")]
        public object QualificationColor { get; set; }
    }
}
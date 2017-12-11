using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fifa.Models
{
   
    public class CompetitionDetail
    {
        [JsonProperty("n_CompetitionID")]
        public int CompetitionId { get; set; }
        [JsonProperty("c_CompetitionNatioShort")]
        public string CompetitionNatioShort { get; set; }
        [JsonProperty("c_Source")]
        public string Source { get; set; }
        [JsonProperty("c_Type")]
        public string Type { get; set; }
        [JsonProperty("c_LogoImage")]
        public string LogoImage { get; set; }
        [JsonProperty("c_Competition_en")]
        public string CompetitionEn { get; set; }
        [JsonProperty("b_Live")]
        public bool Live { get; set; }
        [JsonProperty("matches")]
        public List<Match> Matches { get; set; }
        [JsonProperty("standings")]
        public List<Standing> Standings { get; set; }
        [JsonProperty("topScorers")]
        public List<TopScorer> TopScorers { get; set; }
    }
}

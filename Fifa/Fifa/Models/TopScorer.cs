using Newtonsoft.Json;

namespace Fifa.Models
{
    public class TopScorer
    {
        [JsonProperty("c_Rank")]
        public string Rank { get; set; }
        [JsonProperty("n_PersonID")]
        public int PersonId { get; set; }
        [JsonProperty("c_Person")]
        public string Person { get; set; }
        [JsonProperty("c_PersonShort")]
        public string PersonShort { get; set; }
        [JsonProperty("n_Goals")]
        public int Goals { get; set; }
        [JsonProperty("n_Matches")]
        public int Matches { get; set; }
        [JsonProperty("n_TeamID")]
        public int TeamId { get; set; }
        [JsonProperty("c_TeamShort")]
        public string TeamShort { get; set; }
        [JsonProperty("c_LogoImage")]
        public string LogoImage { get; set; }
        [JsonProperty("c_Team_en")]
        public string TeamEn { get; set; }
    }
}
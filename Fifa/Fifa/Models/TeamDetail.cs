using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fifa.Models
{
    public class TeamDetail
    {
        [JsonProperty("n_TeamID")]
        public int TeamID { get; set; }
        [JsonProperty("c_Type")]
        public string Type { get; set; }
        [JsonProperty("c_TeamNatioShort")]
        public string TeamNatioShort { get; set; }
        [JsonProperty("c_LogoImage")]
        public string LogoImage { get; set; }
        [JsonProperty("c_Team_en")]
        public string TeamEn { get; set; }
        [JsonProperty("c_TeamTypeName_en")]
        public string TeamTypeNameEn { get; set; }
        [JsonProperty("c_TeamTypeName_fr")]
        public string TeamTypeNameFr { get; set; }
        [JsonProperty("c_TeamTypeName_de")]
        public string TeamTypeNameDe { get; set; }
        [JsonProperty("c_TeamTypeName_es")]
        public string TeamTypeNameEs { get; set; }
        [JsonProperty("c_TeamTypeName_pt")]
        public string TeamTypeNamePt { get; set; }
        [JsonProperty("c_TeamTypeName_ru")]
        public string TeamTypeNameRu { get; set; }
        [JsonProperty("latestMatch")]
        public Match LatestMatch { get; set; }
        [JsonProperty("nextMatch")]
        public Match NextMatch { get; set; }
        [JsonProperty("competitions")]
        public List<Competition> Competitions { get; set; }
    }
}
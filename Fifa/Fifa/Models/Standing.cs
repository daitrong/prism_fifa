using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fifa.Models
{
    public class Standing
    {
        [JsonProperty("c_Phase_en")]
        public object PhaseEn { get; set; }
        [JsonProperty("qualifications")]
        public List<Qualification> Qualifications { get; set; }
        [JsonProperty("standings")]
        public List<StandingDetail> Standings { get; set; }
    }
}
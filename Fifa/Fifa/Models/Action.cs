using Newtonsoft.Json;

namespace Fifa.Models
{
    public class Action
    {
        [JsonProperty("c_EventID")]
        public string EventID { get; set; }
        [JsonProperty("c_ActionShort")]
        public string ActionShort { get; set; }
        [JsonProperty("c_HomeOrAway")]
        public string HomeOrAway { get; set; }
        [JsonProperty("n_PersonID")]
        public int PersonID { get; set; }
        [JsonProperty("c_PersonShort")]
        public string PersonShort { get; set; }
        [JsonProperty("c_ActionReason")]
        public string ActionReason { get; set; }
        [JsonProperty("c_ActionInfo")]
        public string ActionInfo { get; set; }
        [JsonProperty("n_SubPersonID")]
        public int SubPersonID { get; set; }
        [JsonProperty("c_SubPersonShort")]
        public string SubPersonShort { get; set; }
        [JsonProperty("c_ActionMinute")]
        public string ActionMinute { get; set; }
    }
}
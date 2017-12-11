using Newtonsoft.Json;

namespace Fifa.Models
{
    public class PersonInfo
    {
        [JsonProperty("c_Person")]
        public string Person { get; set; }
        [JsonProperty("n_PersonID")]
        public int PersonID { get; set; }
        [JsonProperty("c_PersonShort")]
        public string PersonShort { get; set; }
        [JsonProperty("c_FunctionShort")]
        public string FunctionShort { get; set; }
        [JsonProperty("n_ShirtNr")]
        public int ShirtNr { get; set; }
    }
}
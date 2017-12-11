using Newtonsoft.Json;

namespace Fifa.Models
{
    public class Qualification
    {
        [JsonProperty("c_Name_en")]
        public string NameEn { get; set; }
        [JsonProperty("c_Color")]
        public string Color { get; set; }
    }
}
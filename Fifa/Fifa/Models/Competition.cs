using Newtonsoft.Json;
using Xamarin.Forms;

namespace Fifa.Models
{
	public class Competition
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

	    public Color Color => Live ? Color.GreenYellow : Color.LightGray;
	}
	
}
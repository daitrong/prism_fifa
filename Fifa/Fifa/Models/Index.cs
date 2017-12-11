using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fifa.Models
{
	public class Index
	{
		[JsonProperty("competitions")]
		public List<Competition> Competitions { get; set; }
		[JsonProperty("liveCompetitions")]
		public List<string> LiveCompetitions { get; set; }
		[JsonProperty("live")]
		public List<string> Live { get; set; }
		[JsonProperty("b_QualifiersLive")]
		public bool QualifiersLive { get; set; }
	}
	
}
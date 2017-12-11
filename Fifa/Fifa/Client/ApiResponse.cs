using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
namespace Fifa.Client
{
    public class ApiResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ApiResponse<T>: ApiResponse
    {			
		[JsonProperty("data")]
		public T Data { get; set; }
	}
	
}
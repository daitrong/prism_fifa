using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fifa.Client
{
    public class RESTfulService
    {
        readonly HttpClient _client;
        public JsonSerializerSettings JsonSettings { get; }
        public RESTfulService()
        {
            JsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            _client = new HttpClient();
        }
        private HttpRequestMessage CreateRequest(string url, HttpMethod method, HttpContent content)
        {
            var request = new HttpRequestMessage(method, url);
            if (content != null)
                request.Content = content;

            return request;
        }

        private async Task<T> SendAsync<T>(string url, HttpMethod method, HttpContent content) where T : ApiResponse, new()
        {
            try
            {
                Debug.WriteLine($"{method.ToString().ToUpper()}: {url}");
                var response = await _client.SendAsync(CreateRequest(url, method, content));
                var responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine($"RESPONSE {response.StatusCode}: {responseContent}");
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(responseContent, JsonSettings);
                }
                return new T { Success = false };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new HttpRequestException();
            }
        }

        public async Task<ApiResponse<T>> PostJsonAsync<T>(string url, T obj) where T : class
        {
            var json = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            return await PostDataAsync<T>(url, stringContent);
        }


        public async Task<ApiResponse<T>> PostDataAsync<T>(string url, string data, string mediaType) where T : class
        {
            var stringContent = new StringContent(data, Encoding.UTF8, mediaType);
            return await PostDataAsync<T>(url, stringContent);
        }

        public Task<ApiResponse<T>> PostDataAsync<T>(string url, HttpContent content) where T : class
        {
            return SendAsync<ApiResponse<T>>(url, HttpMethod.Post, content);
        }

       
        public Task<ApiResponse<T>> GetAsync<T>(string url, string parameters = "") where T : class
        {
            if (!string.IsNullOrEmpty(parameters))
            {
                url = url + "?" + parameters;
            }

            return SendAsync<ApiResponse<T>>(url, HttpMethod.Get, null);
        }

    }
}

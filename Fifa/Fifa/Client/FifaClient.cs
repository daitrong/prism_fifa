using System.Threading.Tasks;
using Fifa.Models;

namespace Fifa.Client
{
    public class FifaClient
    {
        private static FifaClient _current;
        public static FifaClient Current => _current ?? (_current = new FifaClient());

        private RESTfulService _restfulService;
        public RESTfulService RESTfulService => _restfulService ?? (_restfulService = new RESTfulService());


        private const string Host = "http://live.mobileapp.fifa.com/api/";

        public Task<ApiResponse<Index>> CurrentAsync()
        {
            var api = Host + "mc/current";
            return RESTfulService.GetAsync<Index>(api);
        }
        public Task<ApiResponse<CompetitionDetail>> CompetitionAsync(string id)
        {
            var api = Host + "mc/competition/" + id;
            return RESTfulService.GetAsync<CompetitionDetail>(api);
        }
        public Task<ApiResponse<MatchDetail>> MatchAsync(string id)
        {
            var api = Host + "mc/match/" + id;
            return RESTfulService.GetAsync<MatchDetail>(api);
        }
        public Task<ApiResponse<TeamDetail>> TeamAsync(string id)
        {
            var api = Host + "mc/team/" + id;
            return RESTfulService.GetAsync<TeamDetail>(api);
        }
    }
}

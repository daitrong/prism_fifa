using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fifa.Models;
using Fifa.Client;
namespace Fifa.ViewModels
{
    public class TeamPageViewModel : ViewModelBase
    {
        FifaClient _fifaClient;
        public TeamPageViewModel( INavigationService navigationService) : base ( navigationService)
        {
            _fifaClient = new FifaClient();

        }
        private TeamDetail _teamdetail;

        public TeamDetail TeamDetail
        {
            get => _teamdetail;
            set => SetProperty(ref _teamdetail, value);
        }
        private List<StandingDetail> _standingdetail;

        public List<StandingDetail> StandingDetail
        {
            get => _standingdetail;
            set => SetProperty(ref _standingdetail, value);
        }


        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if ( parameters.TryGetValue("MatchDetail",out string param))
            {

                var result = await _fifaClient.TeamAsync(param.ToString());
                if( result.Success)
                {
                    TeamDetail = result.Data;

                    var result2nd = await _fifaClient.CompetitionAsync(TeamDetail.Competitions[0].CompetitionId.ToString());

                    if ( result2nd.Success)
                    {
                        StandingDetail = result2nd.Data.Standings[0].Standings;
                    }
                }
                
            }
        }
    }
}

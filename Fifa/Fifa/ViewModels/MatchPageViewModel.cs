using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fifa.Models;
using System.Windows.Input;

namespace Fifa.ViewModels
{
    public class MatchPageViewModel : ViewModelBase
    {
        private Fifa.Client.FifaClient _fifaClient;
        public MatchPageViewModel(INavigationService navigationService) : base (navigationService)
        {
            _fifaClient = new Client.FifaClient();
            TeamCommand = new DelegateCommand<object>(ViewTeam);

        }

        private async void ViewTeam(object obj)
        {
            await NavigationService.NavigateAsync("TeamPage", new NavigationParameters() { { "MatchDetail", obj } });
        }

        public ICommand TeamCommand { get; }

        private Fifa.Models.MatchDetail _matchdetail;

        public Fifa.Models.MatchDetail MatchDetail
        {
            get => _matchdetail;
            set => SetProperty(ref _matchdetail , value);
        }

        private List<Models.Action> _homegoals;

        public List<Models.Action> HomeGoals
        {
            get => _homegoals;
            set => SetProperty(ref _homegoals , value);
        }


        private Models.Action _awaygoals;

        public Models.Action AwayGoals
        {
            get => _awaygoals;
            set => SetProperty(ref _awaygoals, value);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if ( parameters.TryGetValue("CompetitionDetail", out Fifa.Models.Match param))
            {
                if ( param is Fifa.Models.Match match)
                {
                    var result = await _fifaClient.MatchAsync(match.MatchId.ToString());

                    if (result.Success)
                    {
                        MatchDetail = result.Data;

                        HomeGoals = result.Data.Actions.Where(m => m.HomeOrAway == "H" && m.ActionShort == "G").ToList();
                       
                        //AwayGoals = result.Data.Actions.Where(m => m.HomeOrAway == "A" && m.ActionShort == "G").ToList();
                        
                    }
                }
                }

        }



    }
}

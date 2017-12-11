using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Fifa.Models;
using Xamarin.Forms;
using Fifa.Views;
using Prism.Navigation;
using Prism.Commands;

namespace Fifa.ViewModels
{
    public class CompetitionPageViewModel : ViewModelBase
    {
        private Fifa.Client.FifaClient _fifaClient;

        public CompetitionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _fifaClient = new Client.FifaClient();
            MatchCommand = new DelegateCommand<Match>(ViewMatch);
        }

        public async void ViewMatch(Match obj)
        {
            NavigationService.NavigateAsync("MatchPage", new NavigationParameters() { { "CompetitionDetail", obj } });
            //await NavigateToPageAsync<MatchDetailPage>(obj);
        }

        private MatchDetail _matchdetail;
        public MatchDetail MatchDetail
        {
            get => _matchdetail;
            set => SetProperty(ref _matchdetail, value);
        }
        private CompetitionDetail _competitionDetail;

        public CompetitionDetail CompetitionDetail
        {
            get => _competitionDetail;
            set =>  SetProperty(ref _competitionDetail ,value);
        }
        public ICommand MatchCommand { get; }


        public override  async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.TryGetValue("Competition", out Competition param))
            {
                if (param is Competition competition)
                {
                    Title = competition.CompetitionEn;

                    IsWaiting = true;
                    var result = await _fifaClient.CompetitionAsync(competition.CompetitionId.ToString());
                    IsWaiting = false;

                    if (result.Success)
                    {
                        CompetitionDetail = result.Data;
                    }
                }
            }
        }
    }
}

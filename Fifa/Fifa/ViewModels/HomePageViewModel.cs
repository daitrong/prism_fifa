using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Fifa.Models;
using Fifa.Views;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Prism.Navigation;
using Prism.Commands;

namespace Fifa.ViewModels
{

        public class HomePageViewModel : ViewModelBase
        {
            Fifa.Client.FifaClient _fifaClient;
        public ICommand DeleteCommand { get; }

        public ICommand RefreshingCommand { get; }
        //public HomePageViewModel()
        //    {
        //        _fifaClient = new Client.FifaClient();
        //    DeleteCommand = new Command(ExecuteDelete);
        //    RefreshingCommand = new Command(ExecuteRefreshing);
        //    }

        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _fifaClient = new Client.FifaClient();
            
            DeleteCommand = new DelegateCommand<object>(ExecuteDelete);
           RefreshingCommand = new DelegateCommand<object>(ExecuteRefreshing);
        }

        private async void ExecuteRefreshing(object obj)
        {
            Competions.Clear();
            var result = await _fifaClient.CurrentAsync();
            if (result.Success)
            {
                Competions = new ObservableCollection<Competition>(result.Data.Competitions);
            }
            IsRefreshing = false;
        }

        private void ExecuteDelete(object obj)
        {
            if (obj is Competition competition)
            {
                Competions.Remove(competition);
            }
        }
        private bool _isrefreshing;
        public bool IsRefreshing
        {
            get => _isrefreshing; set => SetProperty(ref _isrefreshing, value);
        }
        
            private Fifa.Models.Competition _itemSelected;

            public Fifa.Models.Competition ItemSelected
            {
                get { return _itemSelected; }
                set
                {
                if (SetProperty(ref _itemSelected, value))
                    OnCompetitionSelected(_itemSelected);

                  
                }
            }

        private async void OnCompetitionSelected(Competition itemSelected)
        {
            await NavigationService.NavigateAsync("CompetitionPage", new NavigationParameters() { {"Competition", itemSelected } });


            //await NavigateToPageAsync<CompetitionPage>(itemSelected);
        }

        private ObservableCollection<Fifa.Models.Competition> _competions;

            public ObservableCollection<Fifa.Models.Competition> Competions
            {
            get => _competions; set => SetProperty(ref _competions, value);
        }

        public async override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            await LoadAsync();
        }
        private async Task LoadAsync()
            {
                IsWaiting = true;
                var result = await _fifaClient.CurrentAsync();
                IsWaiting = false;
            Competions = new ObservableCollection<Competition>(result.Data.Competitions);
                //ItemSelected = Competions[2];
            }
        }
    }

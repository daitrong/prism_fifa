using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace Fifa.ViewModels
{
    public class ViewModelBase : BindableBase, INavigatedAware
    {
        
        protected INavigationService NavigationService { get; }
        public ViewModelBase(INavigationService navigationService)
        {

            NavigationService = navigationService;

            
        }


        private bool _iswaiting;

        public bool IsWaiting
        {
            get => _iswaiting;
            set
            {
                if (SetProperty(ref _iswaiting, value))
                {
                    RaisePropertyChanged(nameof(IsNotWaiting));
                }
            }
        }


        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title , value);
        }

        public bool IsNotWaiting => !IsWaiting;
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}

using Prism.DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Fifa.Views;
namespace Fifa
{
    public partial class App 
    {
        public App()
        {
        

            //MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
           
                NavigationService.NavigateAsync("/Navigation/HomePage");
        
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<CompetitionPage>();
            Container.RegisterTypeForNavigation<MatchPage>();
            Container.RegisterTypeForNavigation<TeamPage>();
            Container.RegisterTypeForNavigation<NavigationPage>("Navigation");
        }
    }
}

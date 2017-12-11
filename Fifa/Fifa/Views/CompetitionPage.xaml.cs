using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fifa.ViewModels;
using Fifa.Models;
using Fifa;

namespace Fifa.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompetitionPage :ContentPage
    {
        public CompetitionPage()
        {
            InitializeComponent();
        }


        //private void TeamTapped (object sender , EventArgs e)
        //{
        //    var teamID = ((Match)((View)sender).BindingContext).HomeTeamId;
        //    (this.BindingContext as CompetitionViewModel)?.LoadTeam(teamID.ToString());
        //}
    }

    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fifa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchPage : ContentPage
    {
        public MatchPage()
        {
            InitializeComponent();
        }
    }
    public class TeamSelector : DataTemplateSelector
    {

        public DataTemplate HomeTemplate { get; set; }
        public DataTemplate AwayTemplate { get; set; }
        public DataTemplate StartTemplate { get; set; }
        public DataTemplate MidTemplate { get; set; }
        public DataTemplate EndTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Models.Action action)
            {
                if (action.PersonShort != null)
                {
                    if (action.HomeOrAway == "H")
                    {
                        return HomeTemplate;
                    }

                }
                else if (action.PersonShort == null && action.ActionMinute.Replace("'", "") == "0")
                {
                    return StartTemplate;
                }

                else if (action.PersonShort == null && action.ActionMinute.Replace("'", "") == "-")
                {

                    return EndTemplate;
                }
                else
                {
                    return MidTemplate;
                }
            }
            return AwayTemplate;
        }
    }
}

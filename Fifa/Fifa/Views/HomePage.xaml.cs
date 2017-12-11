using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fifa.Models;

namespace Fifa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }

    public class MainTemplateSelector : DataTemplateSelector
    {

        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate LiveTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Competition competition && competition.Live)
            {
                return LiveTemplate;
            }

            return DefaultTemplate;
        }
    }
}

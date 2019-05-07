using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeocachingHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeocacheLoggerPage : ContentPage
    {
        public GeocacheLoggerPage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new GeocacheLoggerDetailPage()));
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
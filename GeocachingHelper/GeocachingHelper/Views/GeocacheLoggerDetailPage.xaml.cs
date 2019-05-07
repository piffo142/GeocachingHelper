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
    public partial class GeocacheLoggerDetailPage : ContentPage
    {
        public GeocacheLoggerDetailPage()
        {
            InitializeComponent();
        }

        private void UpdateFields(object sender,EventArgs a)
        {
            
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Save", "Saved to List", "OK");
            //await DisplayAlert("LogType", LogType.SelectedItem.ToString(), "OK");
            await Navigation.PopModalAsync();
        }

        private void GCCodeEntry_Unfocused(object sender, FocusEventArgs e)
        {
            
            if (GCCodeEntry != null)
            {
                 DisplayAlert("GC Code is ", GCCodeEntry.Text.ToString(), "ok");
            } else
            {
                DisplayAlert("Error", "Enter a valid GC Code", "OK");
                GCCodeEntry.Focus();
            }
            
        }
    }
}
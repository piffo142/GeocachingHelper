using HtmlAgilityPack;
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
            
            if (GCCodeEntry.Text != null)
            {
                 DisplayAlert("GC Code is ", GCCodeEntry.Text.ToString(), "ok");


                string gcInput = GCCodeEntry.Text.ToUpper().ToString();
                var web = (new HtmlWeb());

                var document = web.Load("http://www.coord.info/" + gcInput);

                //https://coord.info/GC2X2XQ

                var page = document.DocumentNode;
                try{
                    string longdesc = document.GetElementbyId("ctl00_ContentBody_LongDescription").InnerText;
                    string shortdesc = document.GetElementbyId("ctl00_ContentBody_ShortDescription").InnerText;
                    string CacheName = document.GetElementbyId("ctl00_ContentBody_CacheName").InnerText;
                    string Hints = document.GetElementbyId("div_hint").InnerText;
                }
                catch{
                    DisplayAlert("Error", "Enter a valid GC Code", "OK");
                    GCCodeEntry.Focus();
                }
            }
            else
            {
                DisplayAlert("Error", "Enter a valid GC Code", "OK");
                GCCodeEntry.Focus();
            }
           
        }
    }
}
using GeocachingHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeocachingHelper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                //todo add new menu items
                new HomeMenuItem {Id = MenuItemType.Welcome, Title="Welcome" },
                new HomeMenuItem {Id = MenuItemType.ROT13Decrypt, Title="ROT 13 Decryptor" },
                new HomeMenuItem {Id = MenuItemType.ROT13Encrypt, Title="ROT 13 Encryptor" },
                new HomeMenuItem {Id = MenuItemType.GeocacheLogger,Title="Geocache Logger"},
                new HomeMenuItem {Id = MenuItemType.About,Title="About the APP"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}
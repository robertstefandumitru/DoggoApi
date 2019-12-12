using DoggoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoggoApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        private MainPage rootPage { get => Application.Current.MainPage as MainPage; }

        private List<HomeMenuItem> homeMenuItems;

        public MenuPage()
        {
            InitializeComponent();

            homeMenuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Id = MenuItemType.Breeds, Title = "Breeds"},
                new HomeMenuItem { Id = MenuItemType.Random, Title = "Random"},
                new HomeMenuItem { Id = MenuItemType.About, Title = "About" }
            };

            listViewMenu.ItemsSource = homeMenuItems;

            listViewMenu.SelectedItem = homeMenuItems[0];
            listViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                {
                    return;
                }

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await rootPage.NavigateFromMenu(id);
            };
        }
    }
}
using DoggoApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoggoApi.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private Dictionary<int, NavigationPage> menuPages = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            menuPages.Add((int)MenuItemType.Breeds, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!menuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Breeds:
                        menuPages.Add(id, new NavigationPage(new BreedsPage()));
                        break;
                    case (int)MenuItemType.Breed:
                        menuPages.Add(id, new NavigationPage(new BreedPage()));
                        break;
                    case (int)MenuItemType.Random:
                        menuPages.Add(id, new NavigationPage(new RandomPage()));
                        break;
                    case (int)MenuItemType.About:
                        menuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = menuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}

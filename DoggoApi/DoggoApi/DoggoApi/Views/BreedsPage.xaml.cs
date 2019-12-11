using DoggoApi.ViewModels;
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
    public partial class BreedsPage : ContentPage
    {
        private BreedsViewModel viewModel;

        public BreedsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new BreedsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Breeds.Count == 0)
            {
                viewModel.LoadBreedsCommand.Execute(null);
            }
        }

        private void BreedsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            breedsListView.SelectedItem = null;
        }
    }
}
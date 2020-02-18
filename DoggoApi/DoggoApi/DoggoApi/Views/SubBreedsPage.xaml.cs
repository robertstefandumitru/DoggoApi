using DoggoApi.Models;
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
    public partial class SubBreedsPage : ContentPage
    {
        private SubBreedsViewModel viewModel;

        public SubBreedsPage(SubBreedsViewModel subBreedsViewModel)
        {
            InitializeComponent();

            BindingContext = viewModel = subBreedsViewModel;
        }

        private async void SubBreedsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as SubBreedModel;

            if (selectedItem == null)
            {
                return;
            }

            await Navigation.PushAsync(new ImageListPage(new ImageListViewModel(viewModel.BreedName, selectedItem.Name, viewModel.ImagesAmount)));

            subBreedsListView.SelectedItem = null;
        }
    }
}
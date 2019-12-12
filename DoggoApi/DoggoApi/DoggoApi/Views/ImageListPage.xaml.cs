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
    public partial class ImageListPage : ContentPage
    {
        private ImageListViewModel viewModel;

        public ImageListPage(ImageListViewModel imageListViewModel)
        {
            InitializeComponent();

            BindingContext = viewModel = imageListViewModel;
        }

        private void ImagesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            imagesListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Images.Count == 0)
            {
                viewModel.LoadImagesCommand.Execute(null);
            }
        }
    }
}
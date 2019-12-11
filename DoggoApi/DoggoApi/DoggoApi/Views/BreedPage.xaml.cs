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
    public partial class BreedPage : ContentPage
    {
        public BreedPage()
        {
            InitializeComponent();

            BindingContext = new BreedsViewModel();
        }
    }
}
using DoggoApi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoggoApi.ViewModels
{
    public class RandomViewModel : BaseViewModel
    {
        private string imageUrl;
        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }
            set
            {
                SetProperty(ref imageUrl, value);
            }
        }

        public Command LoadImageCommand { get; set; }

        public RandomViewModel()
        {
            Title = "Random";

            LoadImageCommand = new Command(async () => await ExecuteLoadImageCommand());
        }

        private async Task ExecuteLoadImageCommand()
        {
            try
            {
                var result = await DoggoService.GetRandomImage();
                ImageUrl = result.Message;
            }
            catch (Exception ex)
            {
            }
        }
    }
}

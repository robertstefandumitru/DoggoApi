using DoggoApi.Dtos;
using DoggoApi.Models;
using DoggoApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoggoApi.ViewModels
{
    public class BreedsViewModel : BaseViewModel
    {
        public ObservableCollection<BreedModel> Breeds { get; set; }

        public Command LoadBreedsCommand { get; set; }

        public BreedsViewModel()
        {
            Title = "Breeds";

            Breeds = new ObservableCollection<BreedModel>();

            LoadBreedsCommand = new Command(async () => await ExecuteLoadBreedsCommand());
        }

        private async Task ExecuteLoadBreedsCommand()
        {
            try
            {
                var result = await DoggoService.GetAllBreeds();

                foreach (var keyValue in result.Message)
                {
                    var subBreeds = new List<SubBreedModel>();

                    foreach (var subBreed in keyValue.Value)
                    {
                        subBreeds.Add(new SubBreedModel { Name = subBreed });
                    }

                    Breeds.Add(new BreedModel { Name = keyValue.Key, SubBreeds = subBreeds });
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}

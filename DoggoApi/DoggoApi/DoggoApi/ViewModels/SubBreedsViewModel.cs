using DoggoApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DoggoApi.ViewModels
{
    public class SubBreedsViewModel
    {
        public ObservableCollection<SubBreedModel> SubBreeds { get; set; }

        public string BreedName { get; set; }

        public SubBreedsViewModel(string breedName, List<SubBreedModel> subBreeds)
        {
            SubBreeds = new ObservableCollection<SubBreedModel>();
            subBreeds.ForEach(sb => SubBreeds.Add(sb));

            BreedName = breedName;
        }
    }
}

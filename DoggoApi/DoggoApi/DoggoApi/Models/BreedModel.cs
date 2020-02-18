using System;
using System.Collections.Generic;
using System.Text;

namespace DoggoApi.Models
{
    public class BreedModel
    {
        public string Name { get; set; }

        public List<SubBreedModel> SubBreeds { get; set; }

        public string SubBreedsCountText { get => "Sub-breeds: " + SubBreeds?.Count; }

        public bool HasSubBreeds { get { return SubBreeds?.Count > 0; } }
    }
}

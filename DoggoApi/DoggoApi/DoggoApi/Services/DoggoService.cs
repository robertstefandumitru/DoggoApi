using DoggoApi.Dtos;
using DoggoApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DoggoApi.Services
{
    public class DoggoService : BaseService
    {
        private const string GET_ALL_BREEDS_ENDPOINT = "breeds/list/all";
        private const string GET_BREED_IMAGES_ENDPOINT = "breed/{0}/images/random/{1}";
        private const string GET_SUB_BREED_IMAGES_ENDPOINT = "breed/{0}/{1}/images/random/{2}";
        private const string GET_RANDOM_IMAGE_ENDPOINT = "breeds/image/random";

        public static async Task<BreedsDto> GetAllBreeds()
        {
            var url = Path.Combine(BASE_API_URL, GET_ALL_BREEDS_ENDPOINT);
            var result = await RestService.GetAsync<BreedsDto>(url);
            return result;
        }

        public static async Task<BreedImagesDto> GetBreedImages(string breedName, int imagesAmount)
        {
            var endpoint = string.Format(GET_BREED_IMAGES_ENDPOINT, breedName, imagesAmount);
            var url = Path.Combine(BASE_API_URL, endpoint);
            var result = await RestService.GetAsync<BreedImagesDto>(url);
            return result;
        }

        public static async Task<BreedImagesDto> GetSubBreedImages(string breedName, string subBreedName, int imagesAmount)
        {
            var endpoint = string.Format(GET_SUB_BREED_IMAGES_ENDPOINT, breedName, subBreedName, imagesAmount);
            var url = Path.Combine(BASE_API_URL, endpoint);
            var result = await RestService.GetAsync<BreedImagesDto>(url);
            return result;
        }

        public static async Task<RandomImageDto> GetRandomImage()
        {
            var url = Path.Combine(BASE_API_URL, GET_RANDOM_IMAGE_ENDPOINT);
            var result = await RestService.GetAsync<RandomImageDto>(url);
            return result;
        }
    }
}

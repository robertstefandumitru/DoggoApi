﻿using DoggoApi.Dtos;
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
    public class ImageListViewModel
    {
        public ObservableCollection<ImageModel> Images { get; set; }

        public Command LoadImagesCommand { get; set; }

        private string breedName;
        private string subBreedName;

        public ImageListViewModel(string breedName, string subBreedName = null)
        {
            this.breedName = breedName;
            this.subBreedName = subBreedName;

            Images = new ObservableCollection<ImageModel>();

            LoadImagesCommand = new Command(async () => await ExecuteLoadImagesCommand());
        }

        private async Task ExecuteLoadImagesCommand()
        {
            try
            {
                BreedImagesDto result;

                if (subBreedName == null)
                {
                    result = await DoggoService.GetBreedImages(breedName);
                }
                else
                {
                    result = await DoggoService.GetSubBreedImages(breedName, subBreedName);
                }

                foreach (var imageUrl in result.Message)
                {
                    Images.Add(new ImageModel { Url = imageUrl });
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
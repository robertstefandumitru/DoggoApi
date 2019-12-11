using System;
using System.Collections.Generic;
using System.Text;

namespace DoggoApi.Models
{
    public enum MenuItemType
    {
        Breeds,
        Breed,
        Random
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DoggoApi.Dtos
{
    public class BreedsDto : BaseDto
    {
        public Dictionary<string, List<string>> Message { get; set; }
    }
}

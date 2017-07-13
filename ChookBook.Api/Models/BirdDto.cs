using System;
using System.Collections.Generic;

namespace ChookBook.Api.Models
{
    public class BirdDto
    {
        public Guid Id { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string ImageFileName { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
    }
}

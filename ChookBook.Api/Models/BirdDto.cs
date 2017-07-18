using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChookBook.Api.Models
{
    public class BirdDto
    {
        [Required]
        public Guid Id { get; set; }

        public string Age { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public string Gender { get; set; }

        public string ImageFileName { get; set; }

        [MaxLength(255)]
        public string NickName { get; set; }

        [Required]
        public string Type { get; set; }

        public string Weight { get; set; }
    }
}

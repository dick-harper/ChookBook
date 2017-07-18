using System.ComponentModel.DataAnnotations;

namespace ChookBook.Api.Models
{
    public class BreedForCreationDto
    {
        public bool ColdHardy { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        public string ImageFileName { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(50)]
        public string EggColor { get; set; }

        [MaxLength(50)]
        public string EggLaying { get; set; }

        [MaxLength(50)]
        public string EggSize { get; set; }
    }
}
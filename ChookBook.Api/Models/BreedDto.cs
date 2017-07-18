using System;

namespace ChookBook.Api.Models
{
    public class BreedDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ColdHardy { get; set; }
        public string Type { get; set; }
        public string ImageFileName { get; set; }
        public string Url { get; set; }
        public string EggColor { get; set; }
        public string EggLaying { get; set; }
        public string EggSize { get; set; }
    }
}
using System.Reflection.Metadata;
using ChookBook.Domain.Enums;

namespace ChookBook.Domain
{
    public class Breed
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ColdHardy { get; set; }
        public EggFacts EggFacts{ get; set; }
        public BirdType Type { get; set; }
        public string ImageFileName { get; set; }
    }
}
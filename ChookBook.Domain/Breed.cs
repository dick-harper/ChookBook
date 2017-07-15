using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using ChookBook.Domain.Enums;

namespace ChookBook.Domain
{
    public class Breed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ColdHardy { get; set; }
        public EggFacts EggFacts{ get; set; }
        public BirdType Type { get; set; }
        public string ImageFileName { get; set; }
        public string Url { get; set; }
        public ICollection<Note> Notes { get; set; }
        
    }
}
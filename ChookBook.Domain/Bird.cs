using System;
using System.Collections.Generic;
using ChookBook.Domain.Enums;
using ChookBook.Domain.Enums.Poultry;

namespace ChookBook.Domain
{
    public class Bird
    {
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
        public Breed Breed { get; set; }
        public string NickName { get; set; }
        public string ImageFileName { get; set; }
        public IList<WeightInfo> Weights { get; set; } = new List<WeightInfo>();
        public ICollection<Note> Notes { get; set; }
        public BirdSize Size { get; set; }
    }
}
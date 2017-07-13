using System;
using System.Collections.Generic;
using ChookBook.Domain.Enums;

namespace ChookBook.Domain
{
    public abstract class Bird
    {
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
        public Breed Breed { get; set; }
        public string NickName { get; set; }
        public string ImageFileName { get; set; }
        public IEnumerable<long> Weights { get; set; }
    }
}
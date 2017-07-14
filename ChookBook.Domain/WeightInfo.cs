using System;

namespace ChookBook.Domain
{
    public class WeightInfo
    {
        public Guid Id { get; set; }
        public Bird Bird { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfWeight { get; set; }
        public User Weigher { get; set; }
    }
}
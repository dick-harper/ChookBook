using System;

namespace ChookBook.Domain
{
    public class Note
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
    }
}
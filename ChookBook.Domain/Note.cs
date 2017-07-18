using System;
using ChookBook.Domain.Enums.Notes;

namespace ChookBook.Domain
{
    public class Note
    {
        public Guid Id { get; set; }
        public Guid EntityId { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public Category Category { get; set; }
    }
}
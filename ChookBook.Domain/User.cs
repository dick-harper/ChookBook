using System;

namespace ChookBook.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public string LoginId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
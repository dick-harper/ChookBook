using System;
using System.Collections.Generic;
using ChookBook.Domain;

namespace ChookBook.Repository
{
    public interface IPoultryRepository
    {
        IEnumerable<Bird> GetPoultry();

        Bird GetBird(Guid id);

    }
}
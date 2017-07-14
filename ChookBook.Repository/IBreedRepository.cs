using System;
using System.Collections.Generic;
using ChookBook.Domain;

namespace ChookBook.Repository
{
    public interface IBreedRepository
    {
        ICollection<Breed> GetBreeds();

        Breed GetBreed(Guid id);
    }
}
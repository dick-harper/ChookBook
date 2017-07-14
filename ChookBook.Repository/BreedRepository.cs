using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ChookBook.Domain;
using ChookBook.Domain.Enums;

namespace ChookBook.Repository
{
    public class BreedRepository : IBreedRepository
    {
        private readonly ICollection<Breed> breeds;

        public BreedRepository()
        {
            this.LoadBreeds();
        }

        public ICollection<Breed> GetBreeds()
        {
            return this.breeds;
        }

        public Breed GetBreed(Guid id)
        {
            return this.breeds.FirstOrDefault(x => x.Id == id);
        }

        private void LoadBreeds()
        {
            var breed = new Breed
            {
                Id = new Guid("4CBD24D28BB148F7BB83C6E23F84BBA7"),
                Name = "Sussex",
                ColdHardy = true,
                ImageFileName = "Sussex.png",
                Type = BirdType.Chicken,
                Description = "Nice bird.",
                Notes = new Collection<Note>(),
                EggFacts = new EggFacts
                {
                    Color = EggColor.LightBrown,
                    Laying = EggLaying.Excellent,
                    Size = EggSize.Large
                }
            };

            this.breeds.Add(breed);


        }
    }
}
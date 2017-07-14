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
        private IList<Breed> breeds;

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
            this.breeds = new List<Breed>();

            var breed = new Breed
            {
                Id = new Guid("4CBD24D28BB148F7BB83C6E23F84BBA7"),
                Type = BirdType.Chicken,
                Name = "Sussex",
                ColdHardy = true,
                ImageFileName = "Sussex.png",
                Url = "https://en.wikipedia.org/wiki/Sussex_chicken",
                Description = "The Sussex chicken is a dual purpose breed of chicken that originated in England around the time of the Roman conquest of Britain that is a popular garden chicken in many countries.They come in eight colours(with a couple more being developed) and have a bantam version at 1/4 size; the bantams may be any of the eight colours.",
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
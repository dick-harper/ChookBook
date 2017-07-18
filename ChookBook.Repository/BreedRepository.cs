using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ChookBook.Domain;
using ChookBook.Domain.Enums;
using ChookBook.Domain.Enums.Poultry;

namespace ChookBook.Repository
{
    public class BreedRepository : IBreedRepository
    {
        private static IList<Breed> breeds;

        public BreedRepository()
        {
            if (breeds == null)
                this.LoadBreeds();
        }

        public ICollection<Breed> GetBreeds()
        {
            return breeds;
        }

        public Breed GetBreed(Guid id)
        {
            return breeds.FirstOrDefault(x => x.Id == id);
        }

        public bool BreedExists(string name)
        {
            return breeds.Any(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        private void LoadBreeds()
        {
            breeds = new List<Breed>();

            var breed = new Breed
            {
                Id = new Guid("78AF1E12-30E8-489C-90F2-23FAE7E43FAC"),
                Type = BirdType.Chicken,
                Name = "Sussex",
                ColdHardy = true,
                ImageFileName = "Sussex.png",
                Url = "https://en.wikipedia.org/wiki/Sussex_chicken",
                Description = "The Sussex chicken is a dual purpose breed of chicken that originated in England around the time of the Roman conquest of Britain that is a popular garden chicken in many countries.They come in eight colours(with a couple more being developed) and have a bantam version at 1/4 size; the bantams may be any of the eight colours.",
                Notes = new Collection<Note>
                {
                    new Note
                    {
                        CreateDate = DateTime.Now.AddDays(-14),
                        Id = new Guid("2C1B0CA0-7F05-4FFB-A577-45750728CD80"),
                        User = new User{FirsName = "Richard", LastName = "Harper"},
                        Text = "So far, I am very happy with the Sussex breed."
                    }
                },
                EggFacts = new EggFacts
                {
                    Color = EggColor.LightBrown,
                    Laying = EggLaying.Excellent,
                    Size = EggSize.Large
                }
            };

            breeds.Add(breed);

            breed = new Breed
            {
                Id = new Guid("8C90118A-F9B1-45F2-8DEE-94AD1AF62FCA"),
                Type = BirdType.Chicken,
                Name = "Ameraucana",
                ColdHardy = true,
                ImageFileName = "Ameraucana.png",
                Url = "https://en.wikipedia.org/wiki/Ameraucana",
                Description = "The Ameraucana is an American breed of domestic chicken. It was developed in the United States in the 1970s, and derives from Araucana chickens brought from Chile. It was bred to retain the blue-egg gene but eliminate the lethal alleles of the parent breed. There are both standard-sized and bantam versions.",
                Notes = new Collection<Note>(),
                EggFacts = new EggFacts
                {
                    Color = EggColor.LightBlue,
                    Laying = EggLaying.Good,
                    Size = EggSize.Large
                }
            };

            breeds.Add(breed);
        }
    }
}
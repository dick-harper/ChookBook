using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ChookBook.Domain;
using ChookBook.Domain.Enums;
using ChookBook.Domain.Enums.Poultry;

namespace ChookBook.Repository
{
    public class PoultryRepository : IPoultryRepository
    {
        private readonly IList<Breed> breeds = new List<Breed>();
        private readonly IList<Bird> poultry = new List<Bird>();

        public PoultryRepository()
        {
            this.LoadBreeds();
            this.LoadPoultry();
        }

        private void LoadBreeds()
        {
            this.breeds.Clear();

            var breed = new Breed
            {
                
                Name = "Sussex",
                ImageFileName = "speckledsussexhen.jpj",
                ColdHardy = true,
                Description = "The Sussex chicken is a dual purpose breed of chicken that originated in England and come in eight colours (with a couple more being developed) and have a bantam version at 1/4 size",
                Type = BirdType.Chicken,
                EggFacts = new EggFacts
                {
                    Color = EggColor.LightBrown,
                    Laying = EggLaying.Excellent,
                    Size = EggSize.Large
                }
            };

            this.breeds.Add(breed);

        }

        private void LoadPoultry()
        {
            this.poultry.Clear();

            var bird = new Bird
            {
                Id = new Guid("F8E0CAFEA4214645957BBE477C0B821E"),
                BirthDate = DateTime.Parse("2016-04-8"),
                Breed = this.breeds.FirstOrDefault(x => x.Name.Equals("Sussex", StringComparison.OrdinalIgnoreCase)),
                ImageFileName = null,
                NickName = "Lady Jane",
                Weights = new Collection<WeightInfo>()
            };

            var weightInfo = new WeightInfo();
            weightInfo.Id = Guid.NewGuid();
            weightInfo.Bird = bird;
            weightInfo.DateOfWeight = DateTime.Parse("2016-09-13");
            weightInfo.Weight = 38.5;
            weightInfo.Weigher = new User
            {
                Active = true,
                Id = Guid.NewGuid(),
                CreateDate = DateTime.Parse("2014-11-26"),
                FirsName = "Ted",
                LastName = "Shred"
            };

            bird.Weights.Add(weightInfo);

            poultry.Add(bird);
        }
        
        public IEnumerable<Bird> GetPoultry()
        {
            return this.poultry;
        }

        public Bird GetBird(Guid id)
        {
            return this.poultry.FirstOrDefault(x => x.Id == id);
        }
    }
}
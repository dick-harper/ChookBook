using ChookBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    public class BreedController : Controller
    {
        private readonly IBreedRepository breedRepository;

        public BreedController()
        {
            this.breedRepository = new BreedRepository();
        }
    }
}
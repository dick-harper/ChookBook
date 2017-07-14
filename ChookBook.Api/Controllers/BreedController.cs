using System;
using ChookBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    [Route("/api/breeds")]
    public class BreedController : Controller
    {
        private readonly IBreedRepository breedRepository;

        public BreedController()
        {
            this.breedRepository = new BreedRepository();
        }

        [HttpGet()]
        public IActionResult GetBreeds()
        {
            return Ok(this.breedRepository.GetBreeds());
        }

        [HttpGet("{id}")]
        public IActionResult GetBreed(Guid id)
        {
            var breed = this.breedRepository.GetBreed(id);

            if(breed == null)
            {
                return NotFound();
            }

            return Ok(breed);
        }
    }
}
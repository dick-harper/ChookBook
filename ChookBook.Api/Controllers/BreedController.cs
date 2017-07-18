using System;
using System.Linq;
using ChookBook.Api.Models;
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

        //[HttpGet("{breedId}/notes")]
        //public IActionResult GetNotes(Guid breedId)
        //{
        //    var breed = this.breedRepository.GetBreed(breedId);

        //    if (breed == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(breed.Notes);
        //}

        [HttpPost]
        public IActionResult CreateBreed([FromBody] BreedForCreationDto breedForCreation)
        {
            if (breedForCreation == null || this.breedRepository.BreedExists(breedForCreation.Name))
            {
                return BadRequest();
            }
            
            // TODO implement auto mapping
            //var breedDto = new BreedDto
            //{
            //    Id = Guid.NewGuid(),
            //    ColdHardy = 
                
            //}; 

            return null;
        }
    }
}
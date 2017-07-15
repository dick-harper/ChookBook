using System;
using System.Linq;
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

        [HttpGet("{breedId}/notes")]
        public IActionResult GetNotes(Guid breedId)
        {
            var breed = this.breedRepository.GetBreed(breedId);

            if (breed == null)
            {
                return NotFound();
            }

            return Ok(breed.Notes);
        }

        [HttpGet("{breedId}/notes/{id}")]
        public IActionResult GetNote(Guid breedId, Guid id)
        {
            var breed = this.breedRepository.GetBreed(breedId);

            if (breed == null)
            {
                return NotFound();
            }

            var note = breed.Notes.FirstOrDefault(x => x.Id == id);

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }
    }
}
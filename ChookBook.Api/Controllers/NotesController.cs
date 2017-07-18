using System;
using ChookBook.Api.Models;
using ChookBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    [Route("api/notes")]
    public class NotesController : Controller
    {
        private readonly INotesRepository notesRepository;
        private readonly IPoultryRepository poultryRepository;

        public NotesController()
        {
            this.notesRepository = new NotesRepository();
            this.poultryRepository = new PoultryRepository();
        }

        //[HttpPost("{birdId}/notes")]
        //public IActionResult CreateNote(Guid birdId,
        //    [FromBody] NoteForCreationDto note)
        //{
        //    if (note == null)
        //    {
        //        return BadRequest();
        //    }

        //    var bird = this.poultryRepository.GetBird(birdId);

        //    if (bird == null)
        //    {
        //        return NotFound();
        //    }

            
        //    return CreatedAtRoute();
        //}
    }
}
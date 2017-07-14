using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChookBook.Api.Models;
using ChookBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    [Route("/api/poultry")]
    public class PoultryController : Controller
    {
        private IPoultryRepository poultryRepository = new PoultryRepository();

        [HttpGet()]
        public IActionResult GetPoultry()
        {
            return Ok(this.poultryRepository.GetPoultry());
        }

        [HttpGet("{id}")]
        public IActionResult GetBird(Guid id)
        {
            var birdToReturn = this.poultryRepository.GetBird(id);

            if (birdToReturn == null)
            {
                return NotFound();
            }

            return Ok(birdToReturn);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChookBook.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    [Route("/api/poultry")]
    public class PoultryController : Controller
    {
        private readonly IEnumerable<BirdDto> poultry = new List<BirdDto>
        {
            new BirdDto
            {
                Id = new Guid("F8E0CAFEA4214645957BBE477C0B821E"),
                Age = "14 months",
                Breed = "Spotted Sussex",
                Gender = "Female/Hen",
                ImageFileName = "Images/Birds/F8E0CAFEA4214645957BBE477C0B821E.jpg",
                NickName = "Lady Gray",
                Type = "Chicken",
                Weight = "3 lbs 6oz"
            },
            new BirdDto
            {
                Id = new Guid("78F83C04DADE4D8C9AD41AC8B3184017"),
                Age = "14 months",
                Breed = "Cornish",
                Gender = "Male/Rooster",
                ImageFileName = "Images/Birds/78F83C04DADE4D8C9AD41AC8B3184017.jpg",
                NickName = "Pumpkin",
                Type = "Chicken",
                Weight = "4 lbs 8oz"
            }
        };

        [HttpGet()]
        public IActionResult GetPoultry()
        {
            return Ok(poultry);
        }

        [HttpGet("{id}")]
        public IActionResult GetBird(Guid id)
        {
            if (poultry.Any(x => x.Id == id))
            {
                return Ok(new BirdDto
                {
                    Id = new Guid("78F83C04DADE4D8C9AD41AC8B3184017"),
                    Age = "14 months",
                    Breed = "Cornish",
                    Gender = "Male/Rooster",
                    ImageFileName = "Images/Birds/78F83C04DADE4D8C9AD41AC8B3184017.jpg",
                    NickName = "Pumpkin",
                    Type = "Chicken",
                    Weight = "4 lbs 8oz",

                });

            }
            return NotFound();
            
        }
    }
}

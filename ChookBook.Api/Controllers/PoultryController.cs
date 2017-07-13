using System.Collections;
using System.Collections.Generic;
using ChookBook.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChookBook.Api.Controllers
{
    [Route("/api/poultry")]
    public class PoultryController : Controller
    {
        [HttpGet()]
        public IActionResult GetPoultry()
        {
            var birds = new List<BirdDto>
            {
                new BirdDto
                {
                    Id = "F8E0CAFEA4214645957BBE477C0B821E",
                    Age = "14 months",
                    Breed = "Spotted Sussex",
                    Gender = "Female/Hen",
                    ImageFileName = "Images/Birds/F8E0CAFEA4214645957BBE477C0B821E.jpg",
                    NickName = "Lady Gray",
                    Type = "Chicken",
                    Weight = "3 lbs 6oz",
                },
                new BirdDto
                {
                    Id = "78F83C04DADE4D8C9AD41AC8B3184017",
                    Age = "14 months",
                    Breed = "Cornish",
                    Gender = "Male/Rooster",
                    ImageFileName = "Images/Birds/78F83C04DADE4D8C9AD41AC8B3184017.jpg",
                    NickName = "Pumpkin",
                    Type = "Chicken",
                    Weight = "4 lbs 8oz",

                }
            };
            return Ok(birds);
        }
    }
}

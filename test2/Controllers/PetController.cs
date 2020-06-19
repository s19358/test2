using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using test2.Models;

namespace test2.Controllers
{

    [Route("api/volunteers")]
    [ApiController]
    public class PetController : ControllerBase
    {
        /*
        IPetService _service;
        public PetController(IPetService service)
        {
            _service = service;
        }
        */
        private readonly PetDBContext _dbcontext;

        public PetController(PetDBContext context)
        {
            _dbcontext = context;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPets(int id , string? year)
        {
         var res = _dbcontext.Volunteer.Any(e => e.IdVolunteer==id);

            if (res == false)
            {
                throw new Exception("There is no such an volunteer.");
            }
  
            if (year == null) {

                var res2 = _dbcontext.Volunteer_Pet.Where(e => e.IdVolunteer == id).Select(e => e.IdPet).ToList();
                var pets = new List<Pet>();
                for (int i = 0; i < res2.Count(); i++)
                {
                    var pet = _dbcontext.Pet.Find(res2.ElementAt(i));
                    pets.Add(pet);
                }

                var result = _dbcontext.Volunteer.Select(e => new { e.IdVolunteer, e.Name, e.Surname, e.Phone,AnimalList = pets });
                return Ok(result);
               
            }


            var res3 = _dbcontext.Volunteer.Include(e=>e.Volunteer_Pets).Where(e => e.IdVolunteer == id && e.StartingDate.Year ==Int32.Parse(year)).ToList();


            return Ok(res3);

            /*
            var pets1 = new List<Pet>();
            for (int i = 0; i < res2.Count(); i++)
            {
                var pet = _dbcontext.Pet.Find(res2.ElementAt(i));
                pets.Add(pet);
            }

            var result = _dbcontext.Volunteer.Select(e => new { e.IdVolunteer, e.Name, e.Surname, e.Phone, AnimalList = pets });

    */




        }

    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/families")]
    [ApiController]
    public class FamiliesController : ControllerBase
    {
        private IFamilyRepo familyRepo;

        public FamiliesController(IFamilyRepo familyRepo)
        {
            this.familyRepo = familyRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetAllFamily([FromQuery] int? minAdultAge, int? maxAdultAge,
            bool? hasChild, bool? hasPet)
        {

            try
            {
                IList<Family> families = await familyRepo.getAllFamily(minAdultAge, maxAdultAge, hasChild, hasPet);
                return Ok(families);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        /*private IList<Adult> FindFamilyWhereAgeIsBetween(Family family, int? minAdultAge, int? maxAdultAge)
        {
            return (minAdultAge != null && maxAdultAge != null) ? 
                family.Adults.Where(adult => adult.Age >= minAdultAge && adult.Age <= maxAdultAge).ToList() : null;
        }
        
        private IList<Adult> FindFamilyWhereAgeIsBiggerThan(Family family, int? minAdultAge)
        {
            IList<Adult> adults = minAdultAge != null ? family.Adults.Where(adult => adult.Age >= minAdultAge).ToList() : null;
            return adults;
        }
        
        private IList<Adult> FindFamilyWhereAgeIsLessThan(Family family, int? maxAdultAge)
        {
            IList<Adult> adults = maxAdultAge != null ? family.Adults.Where(adult => adult.Age <= maxAdultAge).ToList() : null;
            return adults;
        }*/
    }
}
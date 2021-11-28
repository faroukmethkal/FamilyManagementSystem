using System;

using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/children/pets")]
    [ApiController]
    public class ChildrenPetsController : ControllerBase
    {
        private IFamilyRepo familyRepo;

        public ChildrenPetsController(IFamilyRepo familyRepo)
        {
            this.familyRepo = familyRepo;
        }
        

        [HttpPost]
        public async Task<ActionResult> PostChildPet([FromQuery]  int childId, [FromBody] Pet pet)
        {
            try
            {
              await  familyRepo.AddNewChildPet(childId, pet);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

       
        
    }
}
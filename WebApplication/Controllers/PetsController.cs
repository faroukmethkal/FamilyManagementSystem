using System;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private IFamilyRepo familyRepo;

        public PetsController(IFamilyRepo familyRepo)       
        {
            this.familyRepo = familyRepo;
        }

        [HttpGet]
        public async Task<ActionResult<Pet>> GetPet([FromQuery] int pId)
        {
            try
            {
                Pet pet = await familyRepo.GetPet( pId);
                return Ok(pet);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostPet([FromQuery] string streetNum, int houseNum, [FromBody] Pet pet)
        {
            try
            {
                familyRepo.AddNewPet(streetNum,houseNum, pet);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePet([FromBody] Pet pet)
        {
            try
            {
                familyRepo.UpdatePet( pet);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePet([FromQuery] int pId)
        {
            try
            {
                familyRepo.RemovePet( pId);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
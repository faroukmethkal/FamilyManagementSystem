using System;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/children")]
    [ApiController]
    public class ChildrenController : ControllerBase
    { 
        private IFamilyRepo familyRepo;


        public ChildrenController(IFamilyRepo familyRepo)
        {
            this.familyRepo = familyRepo;
        }

        [HttpGet]
        public async Task<ActionResult<Child>> GetChild([FromQuery]  int id)
        {
            try
            {
                Child child = await familyRepo.GetChild( id);

                return Ok(child);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostChild([FromQuery] string streetNum, int houseNum, [FromBody] Child child)
        {
            try
            {
                await familyRepo.AdNewChild(streetNum,houseNum, child);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutChild([FromBody] Child child)
        {
            try
            {
               await familyRepo.UpdateChild( child);

                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteChild([FromQuery] int cId)
        {
            try
            {
               await familyRepo.RemoveChild( cId);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
   
    public class AdultsController : ControllerBase
    {
        private IFamilyRepo familyRepo;

        public AdultsController(IFamilyRepo familyRepo)
        {
            this.familyRepo = familyRepo;
        }
        
        [Route("api/adult")]
        [HttpGet]
        public async Task<ActionResult<Adult>> GetAdult([FromQuery] int aId)
        {

            try
            {
                Adult adult = await familyRepo.GetAdult(aId);

                return Ok(adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [Route("api/adults")]
        [HttpGet]
        public async Task<ActionResult<Adult>> GetAdult([FromQuery] int houseNumber, string houseName)
        {

            try
            {
                IList<Adult> adult = await familyRepo.getAllAdult(houseName, houseNumber);

                return Ok(adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Route("api/adults")]
        [HttpPost]
        public async Task<ActionResult> PostAdult([FromQuery] string streetName, int houseNum, [FromBody] Adult adult)
        {
            try
            {

                await familyRepo.AddNewAdult(streetName,houseNum,adult);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [Route("api/adults")]
        [HttpPut]
        public async Task<ActionResult> UpdateAdult([FromQuery] [FromBody] Adult adult)
        {
            try
            {
                await familyRepo.UpdateAdult(adult);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            
        }
        
        [Route("api/adults")]
        [HttpDelete]
        public async Task<ActionResult> DeleteAdult([FromQuery] int aId)
        {
            try
            {
               await familyRepo.RemoveAdult(aId);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
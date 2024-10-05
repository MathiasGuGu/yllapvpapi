using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;
using YllaPVP.Services;

namespace YllaPVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController(IUserClassService userClassService) : ControllerBase
    {
        [HttpGet]
        [Description("Retrieve a list of all playable classes")]
        public async Task<ActionResult<IEnumerable<UserClassResponseDto>>> GetAllClasses()
        {
            try
            {
                var classes = await userClassService.GetAllClasses();
                return Ok(classes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost]
        [Description("Create a playable class")]
        public async Task<ActionResult<IEnumerable<UserClass>>> CreateClass(UserClassRequestDto c)
        {
            try
            {
                await userClassService.CreateClass(c);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
    }
}

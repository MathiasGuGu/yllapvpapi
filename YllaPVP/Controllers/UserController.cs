using Microsoft.AspNetCore.Mvc;
using YllaPVP.Dtos.RequestDtos;
using YllaPVP.Dtos.ResponseDtos;
using YllaPVP.Repositories.Contracts;
using YllaPVP.Services;

namespace YllaPVP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController( IUserService userService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IList<UserResponseDto>>> GetAllUsers()
        {
            try
            {
                var users = await userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }

        [HttpPost]
        public async Task<ActionResult> AddUser(UserRequestDto u)
        {
            try
            {
                await userService.AddUser(u);
                return StatusCode(StatusCodes.Status201Created, u);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

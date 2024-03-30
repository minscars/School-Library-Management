using LibraryManagement.Application.Interfaces;
using LibraryManagement.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly IUserAccountService _userAccountService;
        public UserAccountsController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request)
        {
            var result = await _userAccountService.LoginAsync(request);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserAccountByIdAsync([FromRoute]Guid id)
        {
            var result = await _userAccountService.GetUserAccountByIdAsync(id);
            if (result.StatusCode == 200)
            {
                result.Data.Avatar = setImageName(result.Data.Avatar);
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}

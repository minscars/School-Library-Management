using LibraryManagement.Application.Interfaces;
using LibraryManagement.DTO.Email;
using Microsoft.AspNetCore.Mvc;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> SendEmailAsync([FromBody] SendEmailRequest request)
        {
            await _emailService.SendEmailAsync(request);
            return Ok();
        }
    }
}
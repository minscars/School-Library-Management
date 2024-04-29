using LibraryManagement.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService _topicService;
        public TopicsController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllTopicAsync()
        {
            var result = await _topicService.GetAllTopicAsync();
            return Ok(result);
        }
    }
}

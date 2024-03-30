using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.FeedBack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBacksController : ControllerBase
    {
        private readonly IFeedBackService _feedBackService;
        public FeedBacksController(IFeedBackService feedBackService)
        {
            _feedBackService = feedBackService;
        }
        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet("{publishedBookId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeedBackAsync(string publishedBookId)
        {
            var result = await _feedBackService.GetFeedBackPublishedBookAsync(publishedBookId);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.UserAvatar = setImageName(p.UserAvatar));
                return Ok(result.Data);
            }
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateNewFeedBackAsync([FromBody] CreateNewFeedBackRequest dto)
        {
            var result = await _feedBackService.CreateNewFeedBackAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeedBackAsync([FromRoute]int Id)
        {
            var result = await _feedBackService.DeleteFeedBackAsync(Id);
            return Ok(result);
        }
    }
}

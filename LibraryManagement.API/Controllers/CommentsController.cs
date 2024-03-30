using LibraryManagement.Application.Interfaces;
using LibraryManagement.DTO.Comment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet("{blogId}")]
        public async Task<IActionResult> GetCommentPost([FromRoute] string blogId)
        {
            var result = await _commentService.GetAllCommentInBlogAsync(blogId);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.UserAvatar = setImageName(p.UserAvatar));

                return Ok(result.Data);
            }
            return Ok(result.Data);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateCommentPost([FromBody] CreateCommentInBlogRequest dto)
        {
            var result = await _commentService.CreateCommentInPostAsync(dto);
            return Ok(result);
        }

        [HttpDelete("{commentId}")]
        public async Task<IActionResult> DeleteCommentPost(int commentId)
        {
            var result = await _commentService.DeleteCommentBlogAsync(commentId);
            return Ok(result);
        }
    }
}

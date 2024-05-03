using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Blog;
using LibraryManagement.DTO.Pagination;
using LibraryManagement.DTO.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;
        public BlogsController(IBlogService postService)
        {
            _blogService = postService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        private string setImagePost(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Posts/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet()]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var result = await _blogService.GetAllAsync();
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.Avatar = setImageName(p.Avatar));
                result.Data.ForEach(p => p.Image = setImagePost(p.Image));
                return Ok(result.Data);
            }
            return Ok(result);
        }

        [HttpPost("GetBlogPagination")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(GetPaginationRequest dto)
        {
            var result = await _blogService.GetAllAsync(dto);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.Avatar = setImageName(p.Avatar));
                result.Data.ForEach(p => p.Image = setImagePost(p.Image));
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet("GetBlogByTopic/{topicId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBlogByTopicAsync(string topicId)
        {
            var result = await _blogService.GetBlogByTopicAsync(topicId);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.Avatar = setImageName(p.Avatar));
                result.Data.ForEach(p => p.Image = setImagePost(p.Image));
                return Ok(result.Data);
            }
            return Ok(result);
        }

        [HttpGet("{AccountId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllByUserId([FromRoute] Guid AccountId)
        {
            var result = await _blogService.GetByUserIdAsync(AccountId);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.Avatar = setImageName(p.Avatar));
                result.Data.ForEach(p => p.Image = setImagePost(p.Image));
                return Ok(result.Data);
            }
            return Ok(result.Data);
        }

        [HttpGet("Detail/{postId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] string postId)
        {
            var result = await _blogService.GetByIdAsync(postId);
            if (result.StatusCode == 200)
            {
                result.Data.Avatar = setImageName(result.Data.Avatar);
                result.Data.Image = setImagePost(result.Data.Image);
                return Ok(result.Data);
            }
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CretaeBlogAsync([FromForm] CreateBlogRequest dto)
        {
            var result = await _blogService.CretaeBlogAsync(dto);
            return Ok(result);
        }

        [HttpGet("Status/{blogStatus}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPostByStatusAsync([FromRoute] StatusBlogEnums.StatusBlog blogStatus)
        {
            var result = await _blogService.GetPostByStatusAsync(blogStatus);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(p => p.Avatar = setImageName(p.Avatar));
                result.Data.ForEach(p => p.Image = setImagePost(p.Image));
            }
            return Ok(result.Data);
        }

        [HttpPut("UpdateStatusBlog")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateStatusBlogAsync([FromBody] UpdateBlogStatusRequest dto)
        {
            var result = await _blogService.UpdateStatusBlog(dto);
            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

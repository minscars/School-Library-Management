using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.DTO.Pagination;
using LibraryManagement.DTO.PublishedBook;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishedBooksController : ControllerBase
    {
        private readonly IPublishedBookService _publishedBookService;
        public PublishedBooksController(IPublishedBookService publisherService)
        {
            _publishedBookService = publisherService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/PublishedBooks/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpPost("GetAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPublishedBookAsync(GetPaginationRequest requestDto)
        {
            var result = await _publishedBookService.GetAllPublishedBookAsync(requestDto);
            if(result.StatusCode == 200)
            {
                result.Data.ForEach(s => s.Image = setImageName(s.Image));
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] string Id)
        {
            var result = await _publishedBookService.GetPublishedBookByIdAsync(Id);
            if (result.StatusCode == 200)
            {
                result.Data.Image = setImageName(result.Data.Image);
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreatePublishedBookAsync(CreatePublishedBookRequest dto)
        {
            var result = await _publishedBookService.CreatePublishedBookAsync(dto);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("TopFive")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublishedBookBorrowedAsync()
        {
            var result = await _publishedBookService.GetPublishedBookBorrowedAsync();
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(s => s.Image = setImageName(s.Image));
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("book-detail-related-list/{publishedBookId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookDetailRelatedListAsync(string publishedBookId)
        {
            var result = await _publishedBookService.GetBookDetailRelatedListAsync(publishedBookId);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetTopPublishedBook")]
        public async Task<IActionResult> GetTopPublishedBookASync()
        {
            var result = await _publishedBookService.GetTopPublishedBookAsync();
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(s => s.Image = setImageName(s.Image));
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

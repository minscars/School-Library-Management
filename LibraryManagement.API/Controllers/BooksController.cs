using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using LibraryManagement.DTO.Book;
using LibraryManagement.DTO.Pagination;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Books/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }


        [HttpPost("GetBookPagination")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllBookAsync([FromBody]GetPaginationRequest requestDto)
        {
            var result = await _bookService.GetAllBookAsync(requestDto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookAsync([FromBody]EditBookDTO request)
        {
            var result = await _bookService.EditAsync(request);
            return Ok(result);
        }

        [HttpGet("GetDetail/{bookId}")]
        public async Task<IActionResult> GetDetailAsync([FromRoute]string bookId)
        {
            var result = await _bookService.GetByIdAsync(bookId);
            return Ok(result.Data);
        }

        [HttpGet("GetAllAuthor")]
        public async Task<IActionResult> GetAllAuthorAsync()
        {
            var result = await _bookService.GetAllAuthorAsync();
            return Ok(result.Data);
        }

        [HttpPost("CreateNewAuthor")]
        public async Task<IActionResult> CreateNewAuthorAsync([FromBody]string authorName)
        {
            var result = await _bookService.CreateNewAuthorAsync(authorName);
            return Ok(result);
        }

        [HttpPost("CreateNewBook")]
        public async Task<IActionResult> CreateNewBookAsync([FromBody]CreateBookDTO request)
        {
            var result = await _bookService.CreateAsync(request);
            return Ok(result);
        }
    }
}

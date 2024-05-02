using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using LibraryManagement.DTO.Book;

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


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bookService.GetAllBookAsync();
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookAsync([FromForm]EditBookDTO request)
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
    }
}

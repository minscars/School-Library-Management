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
    }
}

using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Data.Enums;
using LibraryManagement.DTO.BookRequest;
using LibraryManagement.DTO.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookRequestController : ControllerBase
    {
        private readonly IBookRequestService _bookRequestService;
        public BookRequestController(IBookRequestService bookRequestService)
        {
            _bookRequestService = bookRequestService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/PublishedBooks/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        private string setImageUser(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/Users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpPost("GetAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAsync(GetPaginationRequest requestDto)
        {
            var result = await _bookRequestService.GetAllBookRequestAsync(requestDto);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(r => r.PublishedBookImage = setImageName(r.PublishedBookImage));
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("GetByUserAccount")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookRequestByAccountId(GetBookReuqestPaginationByUserRequest dto)
        {
            var result = await _bookRequestService.GetBookRequestByAccountUserAsync(dto);
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(r => r.PublishedBookImage = setImageName(r.PublishedBookImage));
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{BookRequestId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookRequestById([FromRoute] string BookRequestId)
        {
            var result = await _bookRequestService.GetBookRequestByIdAsync(BookRequestId);
            if (result.StatusCode == 200)
            {
                result.Data.PublishedBookImage = setImageName(result.Data.PublishedBookImage);
                result.Data.UserAvatar = setImageUser(result.Data.UserAvatar);
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateBookRequestAsync([FromBody]CreateBookRequestRequest dto)
        {
            var result = await _bookRequestService.CreateBookRequestAsync(dto);
            return Ok(result);
        }

        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatusBookRequestAsync(UpdateStatusBookrequestRequest requestDto)
        {
            var result = await _bookRequestService.UpdateStatusBookRequestAsync(requestDto);
            if (result.StatusCode == 200)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}

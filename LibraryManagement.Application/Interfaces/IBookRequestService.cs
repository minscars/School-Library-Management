using LibraryManagement.Data.Enums;
using LibraryManagement.DTO.BookRequest;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Pagination;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookRequestService 
    {
        Task<PaginatedList<List<GetAllBookReuqestResponse>>> GetAllBookRequestAsync(GetPaginationRequest requestDto);
        Task<PaginatedList<List<GetBookRequestByAccountUserResponse>>> GetBookRequestByAccountUserAsync(GetBookReuqestPaginationByUserRequest dto);
        Task<ApiResult<GetBookRequestByIdResponse>> GetBookRequestByIdAsync(string Id);
        Task<ApiResult<string>> CreateBookRequestAsync(CreateBookRequestRequest dto);
        Task<ApiResult<bool>> UpdateStatusBookRequestAsync(UpdateStatusBookrequestRequest requestDto);
    }
}

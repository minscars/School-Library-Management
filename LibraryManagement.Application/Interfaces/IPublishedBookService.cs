using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Pagination;
using LibraryManagement.DTO.PublishedBook;

namespace LibraryManagement.Application.Interfaces
{
    public interface IPublishedBookService
    {
        public Task<PaginatedList<List<GetAllPublishedBookResponse>>> GetAllPublishedBookAsync(GetPaginationRequest requestDto);
        public Task<ApiResult<GetPublishedBookResponse>> GetPublishedBookByIdAsync(string Id);
        public Task<ApiResult<bool>> CreatePublishedBookAsync(CreatePublishedBookRequest dto);
        public Task<ApiResult<List<GetAllPublishedBookResponse>>> GetPublishedBookBorrowedAsync();
    }
}

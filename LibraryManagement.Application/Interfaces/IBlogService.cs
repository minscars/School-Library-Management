using LibraryManagement.Data.Enums;
using LibraryManagement.DTO.Blog;
using LibraryManagement.DTO.Book;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBlogService
    {
        public Task<ApiResult<List<GetAllBlogResponse>>> GetAllAsync();
        public Task<ApiResult<List<GetAllBlogByAccountIdResponse>>> GetByUserIdAsync(Guid AccountId);
        public Task<ApiResult<List<GetBlogResponse>>> GetPostByStatusAsync(StatusPostEnums.StatusPost postStatus);
        public Task<ApiResult<GetBlogByIdResponse>> GetByIdAsync(string Id);
        public Task<ApiResult<bool>> CreateNewPostAsync(CreateBlogRequest dto);
    }
}

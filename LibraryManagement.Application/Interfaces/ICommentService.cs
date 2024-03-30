using LibraryManagement.DTO.Comment;
using LibraryManagement.DTO.Contants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface ICommentService
    {
        public Task<ApiResult<List<GetAllCommentInBlogResponse>>> GetAllCommentInBlogAsync(string blogId);
        public Task<ApiResult<bool>> CreateCommentInPostAsync(CreateCommentInBlogRequest dto);
        public Task<ApiResult<bool>> DeleteCommentBlogAsync(int commentId);
    }
}

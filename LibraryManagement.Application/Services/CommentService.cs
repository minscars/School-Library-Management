using AutoMapper;

using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Comment;
using LibraryManagement.DTO.Contants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly LibraryManagementDbContext _context;
        private readonly IMapper _mapper;

        public CommentService(LibraryManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ApiResult<List<GetAllCommentInBlogResponse>>> GetAllCommentInBlogAsync(string blogId)
        {
            if (blogId == null)
            {
                return new ApiResult<List<GetAllCommentInBlogResponse>>(null)
                {
                    Message = "Not found",
                    StatusCode = 404
                };
            }
            var commentList = await _context.Comments
                .Include(c => c.UserAccount)
                .Where(c => c.BlogId == blogId && c.IsDeleted == false)
                .Select(c => new GetAllCommentInBlogResponse()
                {
                    Id = c.Id,
                    BlogId = c.BlogId,
                    Content = c.Content,
                    UserAvatar = c.UserAccount.Avatar,
                    UserName = c.UserAccount.User.Name,
                    CreatedDate = c.CreatedDate
                })
                .ToListAsync();

            if (commentList.Count < 1)
            {
                return new ApiResult<List<GetAllCommentInBlogResponse>>(null)
                {
                    Message = "Do not have comments yet!",
                    StatusCode = 400
                };
            }

            return new ApiResult<List<GetAllCommentInBlogResponse>>(commentList)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> CreateCommentInPostAsync(CreateCommentInBlogRequest dto)
        {
            if (dto == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Not found!",
                    StatusCode = 404
                };
            }

            if (dto.Id != null)
            {
                var comment = new Comment()
                {
                    BlogId = dto.BlogId,
                    Content = dto.Content,
                    UserAccountId = dto.UserAccountId,
                    CreatedDate = DateTime.Now
                };
                await _context.Comments.AddAsync(comment);
            }
            else
            {
                var commentReply = new Comment()
                {
                    BlogId = dto.BlogId,
                    Content = dto.Content,
                    UserAccountId = dto.UserAccountId,
                    CreatedDate = DateTime.Now,
                    ReplyCommentId = dto.Id

                };
                await _context.Comments.AddAsync(commentReply);

            }

            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "You have created comment successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> DeleteCommentBlogAsync(int commentId)
        {
            var comment = await _context.Comments
                .Where(c => c.Id == commentId)
                .Select(c => _mapper.Map<Comment>(c))
                .FirstOrDefaultAsync();

            if (comment == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = $"Couldn't find the comment with id: {commentId}",
                    StatusCode = 404
                };
            }

            comment.IsDeleted = true;
            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = $"Delete the comment with Id = {commentId} successfully!",
                StatusCode = 200
            };

        }


    }
}

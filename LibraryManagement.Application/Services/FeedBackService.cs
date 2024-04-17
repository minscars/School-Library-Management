using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.FeedBack;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagement.Data.Enums.StatusEnums;

namespace LibraryManagement.Application.Services
{
    public class FeedBackService : IFeedBackService
    {
        private readonly LibraryManagementDbContext _context;
        public FeedBackService(LibraryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<GetAllFeedBackResponse>> GetFeedBackPublishedBookAsync(string publishBookId)
        {
            if (publishBookId == null)
            {
                return new ApiResult<GetAllFeedBackResponse>(null)
                {
                    Message = "Some thing went wrong!",
                    StatusCode = 400
                };
            }

            var feedBackList = await _context.FeedBacks
                .Include(f => f.UserAccount).ThenInclude(f => f.User)
                .Where(f => f.PublishedBookId == publishBookId && f.IsDeleted == false)
                .OrderByDescending(f => f.CreatedDate)
                .Select(f => new GetFeedBackPublishedBookResponse()
                {
                    Id = f.Id,
                    Content = f.Content,
                    Rate = f.Rate,
                    PublishedBookId = f.PublishedBookId,
                    UserAccountId = f.UserAccountId,
                    UserAvatar = f.UserAccount.Avatar,
                    UserName = f.UserAccount.User.Name,
                    CreatedDate = f.CreatedDate,
                }).ToListAsync();
            
            if(feedBackList.Count > 0)
            {

                var rate = Math.Round((decimal)(feedBackList.Sum(f => f.Rate) / feedBackList.Count), 1) ;
                var result = new GetAllFeedBackResponse()
                {
                    Total = feedBackList.Count,
                    Rate = rate,
                    ListFeedBacks = feedBackList,
                };
                return new ApiResult<GetAllFeedBackResponse>(result)
                {
                    Message = "",
                    StatusCode = 200
                };
            }

            return new ApiResult<GetAllFeedBackResponse>(null)
            {
                Message = "Some thing went wrong!",
                StatusCode = 400
            };
            
        }

        public async Task<ApiResult<bool>> CreateNewFeedBackAsync(CreateNewFeedBackRequest dto)
        {
            var borrowed = await _context.BookRequests
                .Where(br => br.UserAccountId.ToString() == dto.UserAccountId 
                    && br.BookDetail.PublishedBookId == dto.PublishedBookId 
                    && (br.Status == (int)StatusEnums.Status.Borrowing || br.Status == (int)StatusEnums.Status.Returned))
                .FirstOrDefaultAsync();
            if(borrowed == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "You have not borrowed this book yet!",
                    StatusCode = 400
                };

            }
            var result = new FeedBack()
            {
                Content = dto.Content,
                Rate = dto.Rate,
                UserAccountId = new Guid(dto.UserAccountId),
                PublishedBookId = dto.PublishedBookId,
                CreatedDate = DateTime.Now,
            };
            await _context.FeedBacks.AddAsync(result);
            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Feedback successfully!",
                StatusCode = 200
            };

        }

        public async Task<ApiResult<bool>> DeleteFeedBackAsync(int Id)
        {
            var feedBack = await _context.FeedBacks
                .Where(f => f.Id == Id && f.IsDeleted == false)
                .FirstOrDefaultAsync();
            if(feedBack == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Not found!",
                    StatusCode = 404
                };
            }

           feedBack.IsDeleted = true;
           await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "Deleted this feedback successfully",
                StatusCode = 200
            };
        }
    }
}

using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.BookRequest;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Pagination;
using Microsoft.EntityFrameworkCore;
using static LibraryManagement.Data.Enums.StatusEnums;

namespace LibraryManagement.Application.Services
{
    public class BookRequestService : IBookRequestService
    {
        private readonly LibraryManagementDbContext _context;
        private readonly IEmailService _emailService;
        public BookRequestService(LibraryManagementDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        public async Task<PaginatedList<List<GetAllBookReuqestResponse>>> GetAllBookRequestAsync(GetPaginationRequest requestDto)
        {
            var total = await _context.BookRequests.Where(r => r.IsDeleted == false).ToListAsync();
            var requestList = _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false)
                .OrderByDescending(p => p.CreatedTime)
                .AsQueryable();
            #region Filtering
            if (!string.IsNullOrEmpty(requestDto.Search))
            {
                requestList = requestList.Where(r => r.UserAccount.User.UserCode.Trim().ToLower().Contains(requestDto.Search.ToLower()) && r.IsDeleted == false);
                total = await _context.BookRequests.Where(r => r.UserAccount.User.UserCode.Trim().ToLower().Contains(requestDto.Search.ToLower()) && r.IsDeleted == false).ToListAsync();
            }
            if ((requestDto.Key != 0) && (requestDto.Key != null))
            {
                requestList = requestList.Where(r => r.IsDeleted == false && r.Status == requestDto.Key);
                total = await _context.BookRequests.Where(r => r.IsDeleted == false && r.Status == requestDto.Key).ToListAsync(); 
            }
            #endregion

            requestList = requestList.Skip((requestDto.Page) * requestDto.Limit).Take(requestDto.Limit);
            var result = await requestList.OrderByDescending(p => p.CreatedTime).Select(r => new GetAllBookReuqestResponse()
                {
                    Id = r.Id,
                    Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserName = r.UserAccount.User.Name,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailId = r.BookDetailId,
                    BookCheckoutId = r.BookCheckoutId,
                    BookDetailCode = r.BookDetail.Code,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    DueTime = r.DueTime,
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                    IsExtended = r.IsExtended,
                }).ToListAsync();

            if (result.Count < 1)
            {
                return new PaginatedList<List<GetAllBookReuqestResponse>>(null);
            }
            return new PaginatedList<List<GetAllBookReuqestResponse>>(result)
            {   
                TotalRecord = total.Count,
                PageNumber = requestDto.Page,
                Data = result,
                StatusCode = 200
            };
        }

        public async Task<PaginatedList<List<GetBookRequestByAccountUserResponse>>> GetBookRequestByAccountUserAsync(GetBookReuqestPaginationByUserRequest dto)
        {
            var requestList = _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false && r.UserAccountId.ToString() == dto.UserId)
                .OrderByDescending(p => p.CreatedTime)
                .AsQueryable();

            requestList = requestList.Skip((dto.Page) * dto.Limit).Take(dto.Limit);
            var result = await requestList.OrderByDescending(p => p.CreatedTime)
                .Select(r => new GetBookRequestByAccountUserResponse()
                 {
                     Id = r.Id,
                     Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserName = r.UserAccount.User.Name,
                    PublishedBookId = r.BookDetail.PublishedBookId,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailId = r.BookDetailId,
                    BookDetailCode = r.BookDetail.Code,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    DueTime = r.DueTime,
                    IsExtended = r.IsExtended,
                    
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                    ExtendedTime = r.ExtendedTime
                }).ToListAsync();
            var total = await _context.BookRequests.Where(r => r.IsDeleted == false && r.UserAccountId.ToString() == dto.UserId).ToListAsync();
            if (result.Count < 1)
            {
                return new PaginatedList<List<GetBookRequestByAccountUserResponse>>(null);
            }
            return new PaginatedList<List<GetBookRequestByAccountUserResponse>>(result)
            {
                PageNumber = dto.Page,
                TotalRecord = total.Count,
                StatusCode = 200
            };
        }

        public async Task<ApiResult<GetBookRequestByIdResponse>> GetBookRequestByIdAsync(string Id)
        {
            var reuqest = await _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false && r.Id == Id)
                .Select(r => new GetBookRequestByIdResponse()
                {
                    Id = r.Id,
                    Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserAvatar = r.UserAccount.Avatar,
                    UserName = r.UserAccount.User.Name,
                    UserEmail = r.UserAccount.UserName,
                    UserCode = r.UserAccount.User.UserCode,
                    UserAddress = r.UserAccount.User.Address,
                    UserPhone = r.UserAccount.User.PhoneNumber,
                    PublishedBookId = r.BookDetail.PublishedBookId,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailCode = r.BookDetail.Code,
                    BookCheckoutId = null,
                    BookDetailId = r.BookDetailId,
                    BookTaked = null,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    ExtendedTime = r.ExtendedTime,
                    IsExtended = r.IsExtended,
                    DueTime = r.DueTime,
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                }).FirstOrDefaultAsync();
            var publishedBookAvailable = await _context.BookDetails
                .Where(bd => bd.PublishedBookId == reuqest.PublishedBookId && bd.IsAvailable == true)
                .ToListAsync();
            reuqest.Available = publishedBookAvailable.Count;
            if (reuqest == null)
            {
                return new ApiResult<GetBookRequestByIdResponse>(null)
                {
                    Message = "Not found!",
                    StatusCode = 404
                };
            }
            return new ApiResult<GetBookRequestByIdResponse>(reuqest)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<string>> CreateBookRequestAsync(CreateBookRequestRequest dto)
        {
            var checkExit = await _context.BookRequests
                .Include(br => br.BookDetail).ThenInclude(p => p.PublishedBook)
                .Where(br => br.UserAccountId.ToString() == dto.UserAccountId).ToListAsync();
            var bookDetail = await _context.BookDetails.Where(b => b.Id == dto.BookDetailId).FirstOrDefaultAsync();
            foreach (var br in checkExit)
            {
                if(((Status)br.Status == StatusEnums.Status.Pending || 
                    (Status)br.Status == StatusEnums.Status.Borrowing ||
                    (Status)br.Status == StatusEnums.Status.Approve)
                    && bookDetail.PublishedBookId== br.BookDetail.PublishedBook.Id)
                {
                    return new ApiResult<string>("false")
                    {
                        Message = "You are having a request with this book!",
                        StatusCode = 400
                    };
                }
            }
            var newBookRequest = new BookRequest()
            {
                Id = Guid.NewGuid().ToString(),
                Code = SystemConstant.BOOKREQUEST_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                BookDetailId = dto.BookDetailId,
                UserAccountId = new Guid(dto.UserAccountId),
                Status = (int)StatusEnums.Status.Pending,
                CreatedTime = DateTime.Now,
            };
            bookDetail.Status = (int)StatusEnums.Status.Pending;
            bookDetail.IsAvailable = false;

            await _context.BookRequests.AddAsync(newBookRequest);
            await _context.SaveChangesAsync();
            await _emailService.SendEmailAsync(newBookRequest.Id);

            return new ApiResult<string>(newBookRequest.Id)
            {
                Message = "Create a request successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<string>> CreateBookRequestAsync(AdminCreateBookRequets dto)
        {
            var checkExit = await _context.BookRequests
                .Include(u => u.UserAccount).ThenInclude(u => u.User)
                .Include(br => br.BookDetail).ThenInclude(p => p.PublishedBook)
                .Where(br => br.UserAccount.User.UserCode == dto.UserCode).ToListAsync();
            if (checkExit.Count < 0)
            {
                return new ApiResult<string>("false")
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var bookDetail = await _context.BookDetails.Where(b => b.Code == dto.BookDetailCode).FirstOrDefaultAsync();
            foreach (var br in checkExit)
            {
                if (((Status)br.Status == StatusEnums.Status.Pending ||
                    (Status)br.Status == StatusEnums.Status.Borrowing ||
                    (Status)br.Status == StatusEnums.Status.Approve)
                    && bookDetail.PublishedBookId == br.BookDetail.PublishedBook.Id)
                {
                    return new ApiResult<string>("false")
                    {
                        Message = "Reader has been had a request with this book!",
                        StatusCode = 400
                    };
                }
            }
            var userAccount = await _context.UserAccounts.Where(u => u.User.UserCode == dto.UserCode).FirstOrDefaultAsync();
            var newBookRequest = new BookRequest()
            {
                Id = Guid.NewGuid().ToString(),
                Code = SystemConstant.BOOKREQUEST_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                BookDetailId = bookDetail.Id,
                UserAccountId = userAccount.Id,
                Status = (int)StatusEnums.Status.Borrowing,
                CreatedTime = DateTime.UtcNow,
                BorrowedTime = DateTime.Now,
                ReceivedTime = DateTime.Now,
                DueTime = DateTime.Now.AddDays(14)
        };
            bookDetail.Status = (int)StatusEnums.Status.Borrowing;
            bookDetail.DueTime = DateTime.Now.AddDays(14);
            bookDetail.IsAvailable = false;

            await _context.BookRequests.AddAsync(newBookRequest);
            await _context.SaveChangesAsync();
            await _emailService.SendEmailAsync(newBookRequest.Id);

            return new ApiResult<string>(newBookRequest.Id)
            {
                Message = "Create a request successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> UpdateStatusBookRequestAsync(UpdateStatusBookrequestRequest requestDto)
        {
            var check = await _context.BookRequests
                .Where(b => b.Id == requestDto.BookRequestId && b.IsDeleted == false)
                .FirstOrDefaultAsync();
            var bookDetail = await _context.BookDetails
                .Where(b => b.Id == requestDto.BookDetailId)
                .FirstOrDefaultAsync();

            if (check == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            switch (requestDto.Status)
            {
                case Status.Approve:
                    check.Status = (int)Status.Approve; //approve
                    bookDetail.Status = (int)Status.Approve;
                    check.ApprovedTime = DateTime.Now;
                    check.DueTime = DateTime.Now.AddDays(1);
                    await _context.SaveChangesAsync();
                    await _emailService.SendEmailAsync(check.Id);
                    break;

                case Status.Borrowing:
                    if(requestDto.BookTaked != bookDetail.Code)
                    {
                        return new ApiResult<bool>(false)
                        {
                            Message = $"You must take the book have the Code {bookDetail.Code}",
                            StatusCode = 400
                        };
                    }
                    else
                    {

                        check.Status = (int)Status.Borrowing; //borrow
                        bookDetail.Status = (int)Status.Borrowing;
                        check.ReceivedTime = DateTime.Now;
                        check.BorrowedTime = DateTime.Now;
                        check.DueTime = DateTime.Now.AddDays(14);
                        bookDetail.DueTime = DateTime.Now.AddDays(14);
                        await _context.SaveChangesAsync();
                        await _emailService.SendEmailAsync(check.Id);
                    }
                    break;

                case Status.Returned:
                    if (requestDto.BookTaked != bookDetail.Code)
                    {
                        return new ApiResult<bool>(false)
                        {
                            Message = $"You must return the book have the Code {bookDetail.Code}",
                            StatusCode = 400
                        };
                    }
                    else
                    {
                        check.Status = (int)Status.Returned; //return
                        bookDetail.Status = (int)Status.Available;
                        var publishedBook = await _context.PublishedBooks
                            .Where(p => p.Id == requestDto.PublishedBookId)
                            .FirstOrDefaultAsync();
                        publishedBook.Checkout_visit += 1;
                        check.ReturnedTime = DateTime.Now;
                        bookDetail.IsAvailable = true;
                    }
                    break;

                case Status.Rejected:
                    check.Status = (int)Status.Rejected;
                    bookDetail.Status = (int)Status.Available;
                    check.RejectedTime = DateTime.Now;
                    await _context.SaveChangesAsync();
                    await _emailService.SendEmailAsync(check.Id);
                    break;

                case Status.Cancel:
                    check.Status = (int)Status.Cancel;
                    check.CanceledTime = DateTime.Now;
                    bookDetail.Status = (int)Status.Available;
                    break;

                case Status.Extend:
                    check.ExtendedTime = DateTime.Now;
                    check.DueTime = check.DueTime.Value.AddDays(7);
                    check.IsExtended = true;
                    bookDetail.DueTime = bookDetail.DueTime.Value.AddDays(7);
                    await _context.SaveChangesAsync();
                    await _emailService.SendEmailExtendAsync(check.Id);
                    await _emailService.SendEmailExtendAdminAsync(check.Id);
                    break;

            }

            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "",
                StatusCode = 200
            };
        }
    }
}

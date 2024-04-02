using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Pagination;
using LibraryManagement.DTO.PublishedBook;
using Microsoft.EntityFrameworkCore;
using static LibraryManagement.Data.Enums.StatusEnums;

namespace LibraryManagement.Application.Services
{
    public class PublishedBookService : IPublishedBookService
    {
        private readonly LibraryManagementDbContext _context;
        public PublishedBookService(LibraryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<List<GetAllPublishedBookResponse>>> GetAllPublishedBookAsync(GetPaginationRequest requestDto)
        {
            var total = await _context.PublishedBooks.ToListAsync();
            var bookList = _context.PublishedBooks
                .Include(b => b.Book)
                .Include(b => b.Book.Category)
                .Include(b => b.Publisher)
                .Include(b => b.Book.BookAuthors).ThenInclude(b => b.Author).AsQueryable();
            #region Filtering
            if (!string.IsNullOrEmpty(requestDto.Search))
            {
                bookList = bookList.Where(b => b.Book.Name.Trim().ToLower().Contains(requestDto.Search.ToLower()) && b.Book.IsDeleted == false);
                total = await _context.PublishedBooks.Where(b => b.Book.Name.Trim().ToLower().Contains(requestDto.Search.ToLower()) && b.Book.IsDeleted == false).ToListAsync();
            }
            if ((requestDto.Key !=0) && (requestDto.Key != null))
            {
                bookList = bookList.Where(b => b.Book.CategoryId == requestDto.Key && b.Book.IsDeleted == false);
                total = await _context.PublishedBooks.Where(b => b.Book.CategoryId == requestDto.Key && b.Book.IsDeleted == false).ToListAsync();
            }
            #endregion

            bookList = bookList.Skip((requestDto.Page) * requestDto.Limit).Take(requestDto.Limit);

            var result = await bookList.Select(b => new GetAllPublishedBookResponse()
            {
                    Id = b.Id,
                    Code = b.Code,
                    Title = b.Book.Name,
                    Description = b.Description,
                    Category = b.Book.Category.Name,
                    Image = b.Image,
                    Pages = b.Pages,
                    PublisherName = b.Publisher.Name,
                    PublishedYear = b.PublishedYear,
                    Rating = b.Rating,
                    Checkout_visit = b.Checkout_visit,
                    Authors = b.Book.BookAuthors.Select(a => new Author
                    {
                        Id = a.Author.Id,
                        Name = a.Author.Name,
                    }).ToList(),
                    
            }).ToListAsync();

            if (result.Count < 1)
            {
                return new PaginatedList<List<GetAllPublishedBookResponse>>(null);
            }
            return new PaginatedList<List<GetAllPublishedBookResponse>>(result)
            {
                TotalRecord = total.Count,
                PageNumber = requestDto.Page,
                StatusCode = 200
            };
        }

        public async Task<ApiResult<GetPublishedBookResponse>> GetPublishedBookByIdAsync(string Id)
        {
            var publishedBookAvailable = await _context.BookDetails
                .Where(bd => bd.PublishedBookId == Id && bd.IsAvailable == true)
                .ToListAsync();
            var book = await _context.PublishedBooks
                .Include(b => b.Book)
                .Include(b => b.Book.Category)
                .Include(b => b.Publisher)
                .Include(b => b.Book.BookAuthors).ThenInclude(b => b.Author)
                .Include(b => b.BookShelfDetails!).ThenInclude(b => b.BookShelf!)
                .Where(b => b.Id == Id)
                .Select(b => new GetPublishedBookResponse()
                {
                    Id = b.Id,
                    Code = b.Code,
                    Title = b.Book.Name,
                    Description = b.Description,
                    Category = b.Book.Category.Name,
                    Image = b.Image,
                    Pages = b.Pages,
                    PublisherName = b.Publisher.Name,
                    PublishedYear = b.PublishedYear,
                    Rating = b.Rating,
                    Checkout_visit = b.Checkout_visit,
                    Authors = b.Book.BookAuthors.Select(a => new Author
                    {
                        Id = a.Author.Id,
                        Name = a.Author.Name,
                    }).ToList(),
                    BookLocation = b.BookShelfDetails!.Select(x => new BookShelf
                    {
                        Id = x.BookShelf!.Id,
                        Name = x.BookShelf!.Name,
                    }).ToList(),
                    Available = publishedBookAvailable.Count
                }).FirstOrDefaultAsync();

            if (book == null)
            {
                return new ApiResult<GetPublishedBookResponse>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            return new ApiResult<GetPublishedBookResponse>(book)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> CreatePublishedBookAsync(CreatePublishedBookRequest dto)
        {
            var newPublishedBook = new PublishedBook()
            {
                //Id = SystemConstant.PUBLISHEDBOOK_PREFIX + $"{ DateTime.Now:yyyyMMddHHmmss}",
                Id = Guid.NewGuid().ToString(),
                BookId = dto.BookId,
                Description = dto.Description,
                Image = dto.Image,
                PublisherId = dto.PublisherId,
                PublishedYear = dto.PublishedYear,
                Pages = dto.Pages,
            };

            await _context.PublishedBooks.AddAsync(newPublishedBook);
            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<GetAllPublishedBookResponse>>> GetPublishedBookBorrowedAsync()
        {
            var bookList = await _context.PublishedBooks
            .Include(b => b.Book)
            .Include(b => b.Book.Category)
            .Include(b => b.Publisher)
            .Include(b => b.Book.BookAuthors).ThenInclude(b => b.Author)
            .OrderByDescending(b => b.Checkout_visit).Take(5)
            .Select(b => new GetAllPublishedBookResponse()
            {
                Id = b.Id,
                Code = b.Code,
                Title = b.Book.Name,
                Description = b.Description,
                Category = b.Book.Category.Name,
                Image = b.Image,
                Pages = b.Pages,
                PublisherName = b.Publisher.Name,
                PublishedYear = b.PublishedYear,
                Rating = b.Rating,
                Checkout_visit = b.Checkout_visit,
                Authors = b.Book.BookAuthors.Select(a => new Author
                {
                    Id = a.Author.Id,
                    Name = a.Author.Name,
                }).ToList(),
            }).ToListAsync();

            if (bookList.Count < 1)
            {
                return new ApiResult<List<GetAllPublishedBookResponse>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<GetAllPublishedBookResponse>>(bookList)
            {
                Message = "",
                StatusCode = 200
            };

        }

        public async Task<ApiResult<List<GetBookDetailRelatedListResponse>>> GetBookDetailRelatedListAsync(string publishedBookId)
        {
            var response = await _context.BookDetails.Where(b => b.PublishedBookId == publishedBookId && b.IsDeleted == false).Select(b => new GetBookDetailRelatedListResponse
            {
                Id = b.Id,
                Code = b.Code,
                IsDeleted = b.IsDeleted,
                Status = StatusEnums.GetDisplayName((Status)b.Status),
                CreatedTime = b.CreatedTime,
                LastModifiedTime = b.LastModifiedTime,
                DueTime = b.DueTime,
            }).ToListAsync();

            return new ApiResult<List<GetBookDetailRelatedListResponse>>(response)
            {
                Message = "",
                StatusCode = 200
            };
        }
    }
}

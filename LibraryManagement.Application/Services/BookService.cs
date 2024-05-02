using AutoMapper;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Book;
using LibraryManagement.DTO.Contants;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagement.Application.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryManagementDbContext _context;
        private readonly IFileSerivce _fileServivce;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BookService(LibraryManagementDbContext context, IMapper mapper, IFileSerivce fileSerivce, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _fileServivce = fileSerivce;
            _webHostEnvironment = webHostEnvironment;
        }


        public async Task<ApiResult<List<GetAllBookResponse>>> GetAllBookAsync()
        {
            var bookList = await _context.Books
                .Include(b => b.Category)
                .Where(b => b.IsDeleted == false)
                .OrderByDescending(b => b.CreatedTime)
                .Select(b => new GetAllBookResponse()
                {
                    Id = b.Id,
                    Name = b.Name,
                    CreatedTime = b.CreatedTime,
                    CategoryName = b.Category.Name,
                    Authors = b.BookAuthors.Select(a => new Author
                    {
                        Id = a.Author.Id,
                        Name = a.Author.Name,
                    }).ToList(),
                }).ToListAsync();
            if (bookList.Count < 1)
            {
                return new ApiResult<List<GetAllBookResponse>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<GetAllBookResponse>>(bookList)
            {
                Message = "",
                StatusCode = 200
            };
        }



        public async Task<ApiResult<GetDetailBook>> GetByIdAsync(string id)
        {
            var book = await _context.Books
                .Include(b => b.Category)
                .Where(b => b.IsDeleted == false && b.Id == id)
                .Select(b => new GetDetailBook()
                {
                    Id = b.Id,
                    Name = b.Name,
                    CreatedTime = b.CreatedTime,
                    CategoryName = b.Category.Name,
                    Authors = b.BookAuthors.Select(a => new GetAuthorBookDetail
                    {
                        Value = a.Author.Id,
                        Label = a.Author.Name,
                    }).ToList(),
                }).FirstOrDefaultAsync();
            if (book == null)
            {
                return new ApiResult<GetDetailBook>(null)
                {
                    Message = $"Couldn't find the room with id: {id}",
                    StatusCode = 400
                };
            }
            return new ApiResult<GetDetailBook>(book)
            {
                Message = "",
                StatusCode = 200
            };
        }
        public async Task<ApiResult<List<GetAuthorBookDetail>>> GetAllAuthorAsync()
        {
            var result = await _context.Authors
                .Select(a => new GetAuthorBookDetail()
                {
                    Value = a.Id,
                    Label = a.Name
                }).ToListAsync();
            if(result.Count > 0 )
            {
                return new ApiResult<List<GetAuthorBookDetail>>(result)
                {
                    StatusCode = 200
                };
            }

            return new ApiResult<List<GetAuthorBookDetail>>(null)
            {
                StatusCode = 400
            };
        }

        //    public async Task<ApiResult<List<BookDTO>>> GetByCategoryIdAsync(int categoryId)
        //    {
        //        var bookList = await _context.Books
        //            .Include(b => b.Category)
        //            .Where(b => b.IsDeleted == false && b.CategoryId==categoryId)
        //            .Select(b => _mapper.Map<BookDTO>(b)).ToListAsync();
        //        if (bookList.Count < 1)
        //        {
        //            return new ApiResult<List<BookDTO>>(null)
        //            {
        //                Message = "Something went wrong!",
        //                StatusCode = 400
        //            };
        //        }
        //        return new ApiResult<List<BookDTO>>(bookList)
        //        {
        //            Message = "",
        //            StatusCode = 200
        //        };
        //    }

        //    public async Task<ApiResult<bool>> CreateAsync(CreateBookDTO request)
        //    {
        //        if (request == null)
        //        {
        //            return new ApiResult<bool>(false)
        //            {
        //                Message = "Something went wrong!",
        //                StatusCode = 400
        //            };
        //        }

        //        var imageName = await _fileServivce.UploadFileAsync(request.Image, SystemConstant.IMG_BOOKS_FOLDER);

        //        var book = new Book()
        //        {
        //            Name = request.Name,
        //            Image = imageName,
        //            CategoryId = request.CategoryId,
        //            CreatedTime = DateTime.Now,
        //            Quantity_Import = request.Quantity_Import,
        //            Description = request.Description,

        //        };
        //        await _context.Books.AddAsync(book);
        //        await _context.SaveChangesAsync();

        //        return new ApiResult<bool>(true)
        //        {
        //            Message = "Create new book successfully!",
        //            StatusCode = 200
        //        };
        //    }

        //    public async Task<ApiResult<bool>> DeleteAsync(int Id)
        //    {
        //        var book = await _context.Books.Where(b => b.IsDeleted == false && b.Id == Id).FirstOrDefaultAsync();
        //        if (book == null)
        //        {
        //            return new ApiResult<bool>(false)
        //            {
        //                Message = $"Couldn't find the book with id: {Id}",
        //                StatusCode = 404
        //            };
        //        }
        //        book.IsDeleted = true;
        //        await _context.SaveChangesAsync();
        //        return new ApiResult<bool>(true)
        //        {
        //            Message = $"Delete the book with Id = {Id} successfully!",
        //            StatusCode = 200
        //        };
        //    }

        public async Task<ApiResult<bool>> EditAsync(EditBookDTO request)
        {
            if (request == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var book = await _context.Books.Where(b => b.IsDeleted == false && b.Id == request.Id).FirstOrDefaultAsync();
            if (book == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = $"Couldn't find the book with id: {request.Id}",
                    StatusCode = 404
                };
            }

            book.Name = request.Name;
            book.CategoryId = request.CategoryId;
            book.UpdatedTime = DateTime.Now;

            await _context.SaveChangesAsync();
            return new ApiResult<bool>(true)
            {
                Message = "Edit book successfully!",
                StatusCode = 200
            };
        }

        //    public async Task<ApiResult<List<BookDTO>>> FindByKeyAsync(string key)
        //    {
        //        var bookList = await _context.Books
        //            .Include(b => b.Category)
        //            .Where(b => b.Name.Trim().ToLower().Contains(key.ToLower()) && b.IsDeleted == false)
        //            .Select(b => _mapper.Map<BookDTO>(b)).ToListAsync();

        //        if (bookList.Count < 1)
        //        {
        //            return new ApiResult<List<BookDTO>>(null)
        //            {
        //                Message = "Something went wrong!",
        //                StatusCode = 400
        //            };
        //        }

        //        return new ApiResult<List<BookDTO>>(bookList)
        //        {
        //            Message = "",
        //            StatusCode = 200
        //        };

        //    }

        //    public async Task<ApiResult<List<BookDTO>>> GetTopFiveAsync()
        //    {
        //        var topFiveBook = await _context.Books
        //            .Include(b => b.Category)
        //            .Where(b => b.IsDeleted == false)
        //            .OrderByDescending(b => b.Quantity_Borrowed).Take(5).Select(b => _mapper.Map<BookDTO>(b)).ToListAsync();

        //        if (topFiveBook.Count < 1)
        //        {
        //            return new ApiResult<List<BookDTO>>(null)
        //            {
        //                Message = "Something went wrong!",
        //                StatusCode = 400
        //            };
        //        }
        //        return new ApiResult<List<BookDTO>>(topFiveBook)
        //        {
        //            Message = "",
        //            StatusCode = 200
        //        };
        //    }

        //    public async Task<ApiResult<List<BookDTO>>> GetNewAsync()
        //    {
        //        var newBooks = await _context.Books
        //            .Include(b => b.Category)
        //            .Where(b => b.IsDeleted == false)
        //            .OrderBy(b => b.CreatedTime).Take(3).Select(b => _mapper.Map<BookDTO>(b)).ToListAsync();

        //        if (newBooks.Count < 1)
        //        {
        //            return new ApiResult<List<BookDTO>>(null)
        //            {
        //                Message = "Something went wrong!",
        //                StatusCode = 400
        //            };
        //        }
        //        return new ApiResult<List<BookDTO>>(newBooks)
        //        {
        //            Message = "",
        //            StatusCode = 200
        //        };
        //    }

        //}
    }
}
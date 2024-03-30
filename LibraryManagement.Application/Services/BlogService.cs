using AutoMapper;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Blog;
using LibraryManagement.DTO.Book;
using LibraryManagement.DTO.BorrowBill;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Post;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagement.Data.Enums.StatusPostEnums;

namespace LibraryManagement.Application.Services
{
    public class BlogService : IBlogService
    {
        private readonly LibraryManagementDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileSerivce _fileServivce;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BlogService(LibraryManagementDbContext context, IMapper mapper, IFileSerivce fileSerivce, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _fileServivce = fileSerivce;
        }

        public async Task<ApiResult<List<GetAllBlogResponse>>> GetAllAsync()
        {
            var blogList = await _context.Blogs
                .Include(p => p.UserAccount).ThenInclude(p => p.User)
                .Where(p => p.IsDeleted == false)
                .OrderByDescending(p => p.CreatedDate)
                .Select(p => new GetAllBlogResponse()
                {
                    Id = p.Id,
                    UserAccountId = p.UserAccountId,
                    Avatar = p.UserAccount.Avatar,
                    UserName = p.UserAccount.User.Name,
                    Title = p.Title,
                    Image = p.Image,
                    Content = p.Content,
                    Status = StatusPostEnums.GetDisplayName((StatusPost)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    UpdatedDate = p.UpdatedDate,
                }).ToListAsync();
            if (blogList.Count < 1)
            {
                return new ApiResult<List<GetAllBlogResponse>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<GetAllBlogResponse>>(blogList)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<GetAllBlogByAccountIdResponse>>> GetByUserIdAsync(Guid AccountId)
        {
            var blogList = await _context.Blogs
                    .Include(p => p.UserAccount).ThenInclude(p => p.User)
                    .Where(p => p.IsDeleted == false && p.UserAccountId == AccountId)
                    .OrderByDescending(p => p.CreatedDate)
                    .Select(p => new GetAllBlogByAccountIdResponse()
                    {
                        Id = p.Id,
                        UserAccountId = p.UserAccountId,
                        Avatar = p.UserAccount.Avatar,
                        UserName = p.UserAccount.User.Name,
                        Title = p.Title,
                        Image = p.Image,
                        Content = p.Content,
                        Status = StatusPostEnums.GetDisplayName((StatusPost)p.Status),
                        CreatedDate = p.CreatedDate,
                        IsDeleted = p.IsDeleted,
                        UpdatedDate = p.UpdatedDate,
                    }).ToListAsync();
            if (blogList.Count < 1)
            {
                return new ApiResult<List<GetAllBlogByAccountIdResponse>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            return new ApiResult<List<GetAllBlogByAccountIdResponse>>(blogList)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<GetBlogByIdResponse>> GetByIdAsync(string Id)
        {
            if (Id == null)
            {
                return new ApiResult<GetBlogByIdResponse>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }

            var blog = await _context.Blogs
                .Include(p => p.UserAccount).ThenInclude(p => p.User)
                .Where(p => p.IsDeleted == false && p.Id == Id)
                .OrderByDescending(p => p.CreatedDate)
                .Select(p => new GetBlogByIdResponse()
                {
                    Id = p.Id,
                    UserAccountId = p.UserAccountId,
                    Avatar = p.UserAccount.Avatar,
                    UserName = p.UserAccount.User.Name,
                    Title = p.Title,
                    Image = p.Image,
                    Content = p.Content,
                    Status = StatusPostEnums.GetDisplayName((StatusPost)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    UpdatedDate = p.UpdatedDate,
                }).FirstOrDefaultAsync();

            return new ApiResult<GetBlogByIdResponse>(blog)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> CreateNewPostAsync(CreateBlogRequest dto)
        {
            if (dto == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Not found!",
                    StatusCode = 404
                };
            }
            var imageName = await _fileServivce.UploadFileAsync(dto.Image, SystemConstant.IMG_POSTS_FOLDER);
            var post = new Blog()
            {
                UserAccountId = dto.UserAccountId,
                Content = dto.Content,
                Title = dto.Title,
                CreatedDate = DateTime.Now,
                Image = imageName,
            };

            await _context.Blogs.AddAsync(post);
            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "Create blog successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<GetBlogResponse>>> GetPostByStatusAsync(StatusPostEnums.StatusPost postStatus)
        {
            var checkExit = await _context.Blogs
                .Include(p => p.UserAccount).ThenInclude(p => p.User)
                .Where(p => p.IsDeleted == false && p.Status == (int)postStatus)
                .OrderByDescending(p => p.CreatedDate)
                .Select(p => new GetBlogResponse()
                {
                    Id = p.Id,
                    UserAccountId = p.UserAccountId,
                    Avatar = p.UserAccount.Avatar,
                    UserName = p.UserAccount.User.Name,
                    Title = p.Title,
                    Image = p.Image,
                    Content = p.Content,
                    Status = StatusPostEnums.GetDisplayName((StatusPost)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    UpdatedDate = p.UpdatedDate,
                }).ToListAsync();

            if (checkExit == null)
            {
                return new ApiResult<List<GetBlogResponse>>(null)
                {
                    Message = "Something went wrong!",
                    StatusCode = 404
                };
            }

            return new ApiResult<List<GetBlogResponse>>(checkExit)
            {
                Message = "",
                StatusCode = 200
            };
        }

    }
}

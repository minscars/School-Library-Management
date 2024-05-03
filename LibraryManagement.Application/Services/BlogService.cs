using AutoMapper;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Blog;
using LibraryManagement.DTO.BookRequest;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Pagination;
using LibraryManagement.DTO.Post;
using LibraryManagement.DTO.Request;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using static LibraryManagement.Data.Enums.StatusBlogEnums;
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

        public async Task<PaginatedList<List<GetAllBlogResponse>>> GetAllAsync(GetPaginationRequest dto)
        {
            var total = await _context.Blogs.Where(r => r.IsDeleted == false).ToListAsync();
            var blogList = _context.Blogs
                .Include(p => p.UserAccount).ThenInclude(p => p.User)
                .Where(p => p.IsDeleted == false)
                
                .AsQueryable();

            #region Filtering
            if (!string.IsNullOrEmpty(dto.Search))
            {
                blogList = blogList.Where(r => r.UserAccount.User.UserCode.Trim().ToLower().Contains(dto.Search.ToLower()) && r.IsDeleted == false);
                total = await _context.Blogs.Where(r => r.UserAccount.User.UserCode.Trim().ToLower().Contains(dto.Search.ToLower()) && r.IsDeleted == false).ToListAsync();
            }
            if ((dto.Key != 0) && (dto.Key != null))
            {
                blogList = blogList.Where(r => r.IsDeleted == false && r.Status == dto.Key);
                total = await _context.Blogs.Where(r => r.IsDeleted == false && r.Status == dto.Key).ToListAsync();
            }
            #endregion
            blogList = blogList.Skip((dto.Page) * dto.Limit).Take(dto.Limit);
            var result = await blogList.OrderByDescending(p => p.CreatedDate).Select(p => new GetAllBlogResponse()
                {
                    Id = p.Id,
                    UserAccountId = p.UserAccountId,
                    Avatar = p.UserAccount.Avatar,
                    UserName = p.UserAccount.User.Name,
                    Title = p.Title,
                    Image = p.Image,
                    Content = p.Content,
                    Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    PostedDate = p.PostedDate,
                    TotalComments = p.Comments.Count
                }).ToListAsync();
            if (result.Count < 1)
            {
                return new PaginatedList<List<GetAllBlogResponse>>(null);
            }
            return new PaginatedList<List<GetAllBlogResponse>>(result)
            {
                TotalRecord = total.Count,
                PageNumber = dto.Page,
                Data = result,
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<GetAllBlogResponse>>> GetAllAsync()
        {
            var total = await _context.Blogs.Where(r => r.IsDeleted == false).ToListAsync();
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
                    Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    PostedDate = p.PostedDate,
                    TotalComments = p.Comments.Count
                 }).ToListAsync();
            if (blogList.Count < 1)
            {
                return new ApiResult<List<GetAllBlogResponse>>(null);
            }
            return new ApiResult<List<GetAllBlogResponse>>(blogList)
            {
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
                        Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                        CreatedDate = p.CreatedDate,
                        IsDeleted = p.IsDeleted,
                        PostedDate = p.PostedDate,
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
                    UserCode = p.UserAccount.User.UserCode,
                    Address = p.UserAccount.User.Address,
                    PhoneNumber = p.UserAccount.User.PhoneNumber,
                    Email = p.UserAccount.Email,
                    Title = p.Title,
                    Image = p.Image,
                    Content = p.Content,
                    Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    PostedDate  = p.PostedDate,
                }).FirstOrDefaultAsync();

            return new ApiResult<GetBlogByIdResponse>(blog)
            {
                Message = "",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<bool>> CretaeBlogAsync(CreateBlogRequest dto)
        {
            if (dto == null)
            {
                return new ApiResult<bool>(false)
                {
                    Message = "Something went wrong!",
                    StatusCode = 400
                };
            }
            var post = new Blog()
            {
                Id = SystemConstant.BLOG_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                UserAccountId = dto.UserAccountId,
                TopicId = dto.TopicId,
                Content = dto.Content,
                Title = dto.Title,
                Status =  (int)StatusEnums.StatusPost.Pending,
                CreatedDate = DateTime.Now,
            };

            if (dto.Image != null)
            {
                post.Image = await _fileServivce.UploadFileAsync(dto.Image, SystemConstant.IMG_POSTS_FOLDER);
            }

            await _context.Blogs.AddAsync(post);
            await _context.SaveChangesAsync();

            return new ApiResult<bool>(true)
            {
                Message = "Create blog successfully!",
                StatusCode = 200
            };
        }

        public async Task<ApiResult<List<GetBlogResponse>>> GetPostByStatusAsync(StatusBlogEnums.StatusBlog blogStatus)
        {
            var checkExit = await _context.Blogs
                .Include(p => p.UserAccount).ThenInclude(p => p.User)
                .Where(p => p.IsDeleted == false && p.Status == (int)blogStatus)
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
                    Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                    CreatedDate = p.CreatedDate,
                    IsDeleted = p.IsDeleted,
                    PostedDate = p.PostedDate,
                    TotalComments = p.Comments.Count
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

        public async Task<ApiResult<bool>> UpdateStatusBlog(UpdateBlogStatusRequest dto)
        {
            var blog = await _context.Blogs
                .Where(b => b.Id == dto.BlogId)
                .FirstOrDefaultAsync();
            if (blog != null)
            {
                blog.Status = (int)StatusBlog.Posted;
                blog.PostedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiResult<bool>(true)
                {
                    StatusCode = 200,
                    Message = "The blog have been posted!"
                };
            }
            return new ApiResult<bool>(false)
            {
                Message = "Something went wrong!",
                StatusCode = 400
            };
        }

        public async Task<ApiResult<List<GetAllBlogResponse>>> GetBlogByTopicAsync(string topicId)
        {
            var blogList = await _context.Blogs
            .Include(p => p.UserAccount).ThenInclude(p => p.User)
            .Where(p => p.IsDeleted == false && p.TopicId == topicId)
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
                Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                CreatedDate = p.CreatedDate,
                IsDeleted = p.IsDeleted,
                PostedDate = p.PostedDate,
                TotalComments = p.Comments.Count,
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
    }
}

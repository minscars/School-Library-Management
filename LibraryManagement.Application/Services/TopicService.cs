using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Topic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Services
{
    public class TopicService : ITopicService
    {
        private readonly LibraryManagementDbContext _context;
        public TopicService(LibraryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<List<GetAllTopicResponse>>> GetAllTopicAsync()
        {
            var topicList = await _context.Topics
                .Select(t => new GetAllTopicResponse()
                {
                    TopicId = t.Id, TopicName = t.Name,
                }).ToListAsync();
            if(topicList.Count > 0)
            {
                return new ApiResult<List<GetAllTopicResponse>>(topicList)
                {
                    StatusCode = 200,
                };
            }
            return new ApiResult<List<GetAllTopicResponse>>(null)
            {
                StatusCode = 400,
                Message = "Something went wrong!"
            };
        }
    }
}

using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface ITopicService
    {
        Task<ApiResult<List<GetAllTopicResponse>>> GetAllTopicAsync();
    }
}

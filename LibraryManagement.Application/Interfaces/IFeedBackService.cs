using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.FeedBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IFeedBackService
    {
        Task<ApiResult<GetAllFeedBackResponse>> GetFeedBackPublishedBookAsync(string publishBookId);
        Task<ApiResult<bool>> CreateNewFeedBackAsync(CreateNewFeedBackRequest dto);
        Task<ApiResult<bool>> DeleteFeedBackAsync(int Id);
    }
}

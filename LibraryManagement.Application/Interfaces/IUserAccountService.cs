using LibraryManagement.Data.Models;
using LibraryManagement.DTO.Account;
using LibraryManagement.DTO.Contants;
using LibraryManagement.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IUserAccountService
    {
        //Task<ApiResult<bool>> RegisterAsync(RegisterRequest request);
        Task<ApiResult<string>> LoginAsync(LoginRequest request);
        Task<ApiResult<GetUserAccountResponse>> GetUserAccountByIdAsync(Guid id);
    }
}

using LibraryManagement.DTO.Email;

namespace LibraryManagement.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(SendEmailRequest request);
    }
}

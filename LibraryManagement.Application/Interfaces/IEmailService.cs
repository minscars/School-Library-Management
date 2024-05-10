using LibraryManagement.DTO.Email;

namespace LibraryManagement.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string bookRequestId);
        Task SendEmailExtendAsync(string bookRequestId);
        Task SendEmailExtendAdminAsync(string bookRequestId);
        Task SendMailBlogAsync(string blogId);
    }
}

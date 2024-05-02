using LibraryManagement.Application.Interfaces;
using LibraryManagement.DTO.Email;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace TheSkyHomestay.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(SendEmailRequest request)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Thư viện Trường CNTT", _configuration["EmailSettings:AdminEmailAddress"]));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = GetEmailContent();
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync(_configuration["EmailSettings:EmailHost"], 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(_configuration["EmailSettings:AdminEmailAddress"], _configuration["EmailSettings:AdminEmailPassword"]);
            await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
        }

        private string GetEmailContent()
        {
            var content = $"<p>Mến chào bạn đọc!</p>";
            content += $"<p>Ban quản lý Thư viện trường CNTT xin được xác nhận với bạn đọc thông tin mượn sách như sau:</p>";
            content += $"<ul>" +
                        $"<li>Tên sách: Send email using MailKit in ASP.NET Core</li>" +
                        $"<li>Ngày nhận sách: 02/05/2024</li>" +
                        $"<li>Ngày trả sách: 15/05/2024</li>" +
                    $"</ul>";

            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: thuvien.cntt@ctu.edu.vn</li>" +
                            $"<li>Số điện thoại: 0338 307 449 (gặp cô Chung)</li>" +
                        $"</ul>";

            return content;
        }
    }
}
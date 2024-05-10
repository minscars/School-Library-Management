using DotLiquid.Tags;
using DotLiquid.Util;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Data.EF;
using LibraryManagement.Data.Enums;
using LibraryManagement.DTO.Blog;
using LibraryManagement.DTO.BookRequest;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using static LibraryManagement.Data.Enums.StatusBlogEnums;
using static LibraryManagement.Data.Enums.StatusEnums;

namespace LibraryManagement.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly LibraryManagementDbContext _context;

        public EmailService(IConfiguration configuration, LibraryManagementDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task SendEmailAsync(string bookRequestId)
        {
            var bookRequest = await _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false && r.Id == bookRequestId)
                .Select(r => new GetBookRequestByIdResponse()
                {
                    Id = r.Id,
                    Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserAvatar = r.UserAccount.Avatar,
                    UserName = r.UserAccount.User.Name,
                    UserEmail = r.UserAccount.UserName,
                    UserCode = r.UserAccount.User.UserCode,
                    UserAddress = r.UserAccount.User.Address,
                    UserPhone = r.UserAccount.User.PhoneNumber,
                    PublishedBookId = r.BookDetail.PublishedBookId,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailCode = r.BookDetail.Code,
                    BookCheckoutId = null,
                    BookDetailId = r.BookDetailId,
                    BookTaked = null,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    DueTime = r.DueTime,
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                }).FirstOrDefaultAsync();

            var email = new MimeMessage();
            var builder = new BodyBuilder();
            email.From.Add(new MailboxAddress("MinsCars Library", _configuration["EmailSettings:AdminEmailAddress"]));
            if(bookRequest.Status == "Pending")
            {
                email.To.Add(MailboxAddress.Parse("khakhongkhung@gmail.com"));
            }else
            {
                email.To.Add(MailboxAddress.Parse(bookRequest.UserEmail));
            }
            switch (bookRequest.Status)
            {
                case "Pending":
                    builder.HtmlBody = GetPendingEmailContent(bookRequest);
                    email.Subject = "[MinsCars Library] Hệ thống có yêu cầu mới";
                    break;
                case "Approve":
                    builder.HtmlBody = GetApproveEmailContent(bookRequest);
                    email.Subject = "[MinsCars Library] Thông báo đã duyệt yêu cầu mượn sách";
                    break;

                case "Borrowing":
                    builder.HtmlBody = GetBorrowingEmailContent(bookRequest);
                    email.Subject = "[MinsCars Library] Xác nhận thông tin mượn sách";
                    break;
                case "Rejected":
                    builder.HtmlBody = GetRejectedEmailContent(bookRequest);
                    email.Subject = "[MinsCars Library] Thông báo từ chối yêu cầu mượn sách";
                    break;

                case "Extend":
                    builder.HtmlBody = GetExtendEmailContent(bookRequest);
                    email.Subject = "[MinsCars Library] Xác nhận thông tin gia hạn thời gian mượn sách";
                    break;
             }

            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync(_configuration["EmailSettings:EmailHost"], 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(_configuration["EmailSettings:AdminEmailAddress"], _configuration["EmailSettings:AdminEmailPassword"]);
            await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
        }

        public async Task SendEmailExtendAsync(string bookRequestId)
        {
            var bookRequest = await _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false && r.Id == bookRequestId)
                .Select(r => new GetBookRequestByIdResponse()
                {
                    Id = r.Id,
                    Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserAvatar = r.UserAccount.Avatar,
                    UserName = r.UserAccount.User.Name,
                    UserEmail = r.UserAccount.UserName,
                    UserCode = r.UserAccount.User.UserCode,
                    UserAddress = r.UserAccount.User.Address,
                    UserPhone = r.UserAccount.User.PhoneNumber,
                    PublishedBookId = r.BookDetail.PublishedBookId,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailCode = r.BookDetail.Code,
                    BookCheckoutId = null,
                    BookDetailId = r.BookDetailId,
                    BookTaked = null,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    DueTime = r.DueTime,
                    ExtendedTime = r.ExtendedTime,
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                }).FirstOrDefaultAsync();

            var email = new MimeMessage();
            var builder = new BodyBuilder();
            email.From.Add(new MailboxAddress("MinsCars Library", _configuration["EmailSettings:AdminEmailAddress"]));
            email.To.Add(MailboxAddress.Parse(bookRequest.UserEmail));
            builder.HtmlBody = GetExtendEmailContent(bookRequest);
            email.Subject = "[MinsCars Library] Xác nhận thông tin gia hạn thời gian mượn sách";
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync(_configuration["EmailSettings:EmailHost"], 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(_configuration["EmailSettings:AdminEmailAddress"], _configuration["EmailSettings:AdminEmailPassword"]);
            await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
        }

        public async Task SendEmailExtendAdminAsync(string bookRequestId)
        {
            var bookRequest = await _context.BookRequests
                .Include(r => r.BookDetail)
                .Include(r => r.UserAccount).ThenInclude(r => r.User)
                .Where(r => r.IsDeleted == false && r.Id == bookRequestId)
                .Select(r => new GetBookRequestByIdResponse()
                {
                    Id = r.Id,
                    Code = r.Code,
                    UserAccountId = r.UserAccountId.ToString(),
                    UserAvatar = r.UserAccount.Avatar,
                    UserName = r.UserAccount.User.Name,
                    UserEmail = r.UserAccount.UserName,
                    UserCode = r.UserAccount.User.UserCode,
                    UserAddress = r.UserAccount.User.Address,
                    UserPhone = r.UserAccount.User.PhoneNumber,
                    PublishedBookId = r.BookDetail.PublishedBookId,
                    PublishedBookName = r.BookDetail.PublishedBook.Book.Name,
                    PublishedBookImage = r.BookDetail.PublishedBook.Image,
                    BookDetailCode = r.BookDetail.Code,
                    BookCheckoutId = null,
                    BookDetailId = r.BookDetailId,
                    BookTaked = null,
                    Status = StatusEnums.GetDisplayName((Status)r.Status),
                    CreatedTime = r.CreatedTime,
                    RejectedTime = r.RejectedTime,
                    ApprovedTime = r.ApprovedTime,
                    ReceivedTime = r.ReceivedTime,
                    BorrowedTime = r.BorrowedTime,
                    DueTime = r.DueTime,
                    ExtendedTime = r.ExtendedTime,
                    ReturnedTime = r.ReturnedTime,
                    CanceledTime = r.CanceledTime,
                }).FirstOrDefaultAsync();

            var email = new MimeMessage();
            var builder = new BodyBuilder();
            email.From.Add(new MailboxAddress("MinsCars Library", _configuration["EmailSettings:AdminEmailAddress"]));
            email.To.Add(MailboxAddress.Parse("khakhongkhung@gmail.com"));
            builder.HtmlBody = GetExtendEmailAdminContent(bookRequest);
            email.Subject = "[MinsCars Library] Xác nhận thông tin gia hạn thời gian mượn sách";
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync(_configuration["EmailSettings:EmailHost"], 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(_configuration["EmailSettings:AdminEmailAddress"], _configuration["EmailSettings:AdminEmailPassword"]);
            await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
        }

        public async Task SendMailBlogAsync(string blogId)
        {
            var blog = await _context.Blogs
                 .Include(p => p.UserAccount).ThenInclude(p => p.User)
                 .Where(p => p.IsDeleted == false && p.Id == blogId)
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
                     Email = p.UserAccount.UserName,
                     Title = p.Title,
                     Image = p.Image,
                     Content = p.Content,
                     Status = StatusBlogEnums.GetDisplayName((StatusBlog)p.Status),
                     CreatedDate = p.CreatedDate,
                     IsDeleted = p.IsDeleted,
                     PostedDate = p.PostedDate,
                 }).FirstOrDefaultAsync();

            var email = new MimeMessage();
            var builder = new BodyBuilder();
            email.From.Add(new MailboxAddress("MinsCars Library", _configuration["EmailSettings:AdminEmailAddress"]));
            if(blog.Status == "Pending")
            {

                email.To.Add(MailboxAddress.Parse("khakhongkhung@gmail.com"));
                builder.HtmlBody = GetNewBlogContent(blog);
                email.Subject = "[MinsCars Library] Hệ thống vừa nhận được yêu cầu đăng bài blog mới";
            }else if(blog.Status == "Posted")
            {
                email.To.Add(MailboxAddress.Parse(blog.Email));
                builder.HtmlBody = GetApproveBlogEmailContent(blog);
                email.Subject = "[MinsCars Library] Thông báo đã duyệt yêu cầu đăng bài blog";
            }
            else
            {
                email.To.Add(MailboxAddress.Parse(blog.Email));
                builder.HtmlBody = GetRejectedBlogEmailContent(blog);
                email.Subject = "[MinsCars Library] Thông báo từ chối yêu cầu đăng bài blog";
            }
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync(_configuration["EmailSettings:EmailHost"], 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(_configuration["EmailSettings:AdminEmailAddress"], _configuration["EmailSettings:AdminEmailPassword"]);
            await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
        }

        private string GetApproveEmailContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Mến chào bạn đọc!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc thông tin yêu cầu mượn sách như sau:</p>";
            content += $"<ul>" +
                        $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                        $"<li>Tên sách: {bookRequest.PublishedBookName}" +
                        $"<li>Mã sách: {bookRequest.BookDetailCode}" +
                        $"<li>Yêu cầu mượn sách <b>đã được duyệt</b> vào ngày lúc: <b>{bookRequest.ApprovedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                       $"</ul>";
            content += $"<p> Bạn đọc vui lòng đến thư viện vào ngày <b>{bookRequest.DueTime.Value.ToString("dd/MM/yyyy")}</b> để lấy sách! " +
                       $"Bạn nhớ lấy đúng quyển sách có mã <b>{bookRequest.BookDetailCode}</b> và gặp Thủ thư xác nhận!" +
                       $"Sau thời gian trên, bạn đọc không đến lấy sách thì yêu cầu mượn sách sẽ tự động hủy!</p>";
            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }

        private string GetBorrowingEmailContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Mến chào bạn đọc!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc thông tin yêu cầu mượn sách như sau:</p>";
            content += $"<ul>" +
                        $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                        $"<li>Tên sách: <b>{bookRequest.PublishedBookName}</b>" +
                        $"<li>Mã sách: <b>{bookRequest.BookDetailCode}</b>" + 
                        $"<li>Ngày nhận sách: <b>{bookRequest.BorrowedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                        $"<li>Ngày trả sách: <b>{bookRequest.DueTime.Value.ToString("dd/MM/yyyy")}</b></li>" +
                    $"</ul>";

            content += $"<p> Bạn đọc có thể <b>gia hạn tài liệu</b> tại mục <b>Yêu cầu</b> trong hệ thống!</p>";
            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót và bạn nhớ trả sách đúng hạn nhé!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }

        private string GetRejectedEmailContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Mến chào bạn đọc!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc yêu cầu mượn sách của bạn đã bị hủy với thông tin cụ thể như sau:</p>";
            content += $"<ul>" +
                            $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                            $"<li>Tên sách: <b>{bookRequest.PublishedBookName}</b>" +
                            $"<li>Mã sách: <b>{bookRequest.BookDetailCode}</b>" +
                            $"<li>Ngày tạo yêu cầu: <b>{bookRequest.CreatedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Ngày dự kiến nhận sách: <b>{bookRequest.DueTime.Value.ToString("dd/MM/yyyy")}</b></li>" +
                            $"<li>Trạng thái yêu cầu: <b>Đã bị hủy</b></li>" +
                            $"<li>Lý do: <b>Không đến lấy sách đúng hạn.</b></li>" +
                        $"</ul>";

            content += $"<p>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi! Bạn có thể tạo yêu cầu mượn sách mới tại hệ thống thư viện nhé! </p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }

        private string GetPendingEmailContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Chào John!</p>";
            content += $"<p>Hệ thống vừa nhận được một yêu cầu mượn sách mới, thông tin yêu cầu như sau:</p>";
            content += $"<ul>" +
                            $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                            $"<li>Tên sách: <b>{bookRequest.PublishedBookName}</b>" +
                            $"<li>Mã sách: <b>{bookRequest.BookDetailCode}</b>" +
                            $"<li>Ngày tạo yêu cầu: <b>{bookRequest.CreatedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Trạng thái yêu cầu: <b>{bookRequest.Status}</b></li>" +
                        $"</ul>";

            content += $"<p>Bạn vào hệ thống để xem cụ thể nhé! </p>";

            return content;
        }

        private string GetExtendEmailContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Mến chào bạn đọc!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc thông tin yêu cầu gian hạn thời gian sách như sau:</p>";
            content += $"<ul>" +
                        $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                        $"<li>Tên sách: <b>{bookRequest.PublishedBookName}</b>" +
                        $"<li>Mã sách: <b>{bookRequest.BookDetailCode}</b>" +
                        $"<li>Ngày nhận sách: <b>{bookRequest.BorrowedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>";

            content += $"<li>Thời gian gia hạn: <b>{bookRequest.ExtendedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>";

           content+=             $"<li>Ngày trả sách: <b>{bookRequest.DueTime.Value.ToString("dd/MM/yyyy")}</b></li>" +
                    $"</ul>";
            content += $"<p> <b>Lưu ý:</b> Bạn đọc chỉ <b>gia hạn mượn tài liệu được 01 lần</b>!</p>";
            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót và bạn nhớ trả sách đúng hạn nhé!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }

        private string GetExtendEmailAdminContent(GetBookRequestByIdResponse bookRequest)
        {
            var content = $"<p>Chào John!</p>";
            content += $"<p>Độc giả <b>{bookRequest.UserName}</b> vừa gian hạn thời gian mượn tài liệu, thông tin yêu cầu như sau:</p>";
            content += $"<ul>" +
                            $"<li>Mã yêu cầu: <b>{bookRequest.Code}</b>" +
                            $"<li>Tên sách: <b>{bookRequest.PublishedBookName}</b>" +
                            $"<li>Mã sách: <b>{bookRequest.BookDetailCode}</b>" +
                            $"<li>Ngày tạo yêu cầu: <b>{bookRequest.CreatedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Ngày nhận sách: <b>{bookRequest.BorrowedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Thời gian gia hạn: <b>{bookRequest.ExtendedTime.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Ngày trả sách: <b>{bookRequest.DueTime.Value.ToString("dd/MM/yyyy")}</b></li>" +
                            $"<li>Trạng thái yêu cầu: <b>{bookRequest.Status}</b></li>" +
                        $"</ul>";

            content += $"<p>Bạn vào hệ thống để xem cụ thể nhé! </p>";

            return content;
        }

        private string GetNewBlogContent(GetBlogByIdResponse blog)
        {
            var content = $"<p>Chào John!</p>";
            content += $"<p>Hệ thống vừa nhận được một yêu cầu đăng bài blog mới, thông tin yêu cầu như sau:</p>";
            content += $"<ul>" +
                            $"<li>Tiêu đề: <b>{blog.Title}</b>" +
                            $"<li>Độc giả: <b>{blog.UserName}</b>" +
                            $"<li>Ngày tạo yêu cầu: <b>{blog.CreatedDate.Value.ToString("dd/MM/yyyy HH:mm")}</b></li>" +
                            $"<li>Trạng thái yêu cầu: <b>{blog.Status}</b></li>" +
                        $"</ul>";

            content += $"<p>Bạn vào hệ thống để xem cụ thể nhé! </p>";

            return content;
        }

        private string GetApproveBlogEmailContent(GetBlogByIdResponse blog)
        {
            var content = $"<p>Mến chào bạn đọc <b>{blog.UserName}</b>!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc yêu cầu đăng bài blog của bạn <b>đã được duyệt</b>!</p>";
            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }

        private string GetRejectedBlogEmailContent(GetBlogByIdResponse blog)
        {
            var content = $"<p>Mến chào bạn đọc <b>{blog.UserName}</b>!</p>";
            content += $"<p>Ban quản lý MinsCars Library xin được thông báo với bạn đọc yêu cầu đăng bài blog của bạn <b>đã bị từ chối<b/> vì lý do vi phạm thuần phong mỹ tục!</p>";
            content += $"<p> Bạn đọc vui lòng kiểm tra lại thông tin và liên hệ ngay với thu thư nếu có sai sót!</p>";
            content += $"<p>Mọi chi tiết vui lòng liên hệ: </p>";
            content += $"<ul>" +
                            $"<li>Email: minscarslibrary@gmail.com</li>" +
                            $"<li>Số điện thoại: 0398 897 634 (gặp cô Thủ thư xinh đẹp)</li>" +
                        $"</ul>";

            return content;
        }
    }
}
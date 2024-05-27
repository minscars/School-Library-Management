/*
 Navicat Premium Data Transfer

 Source Server         : sqlserver
 Source Server Type    : SQL Server
 Source Server Version : 16001000
 Source Host           : localhost\SQLEXPRESS:1433
 Source Catalog        : NewDbLibraryManagement
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000
 File Encoding         : 65001

 Date: 27/05/2024 23:29:43
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240331110721_initials', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240415084253_seed-data-for-two-users', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240416082902_update-bookrequest-table', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425090835_update-blog-entities', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425163938_update-publishedBook-entities', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240426052304_add-topic-entities', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240430081119_add-reply-entities', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240501152054_seed-data-userAccount', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240501152947_update-data-userAccount', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240502092008_fix-data-userAccount', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240507151106_update-admin-account', N'7.0.11')
GO

INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240509154204_update-bookRequets-entities', N'7.0.11')
GO


-- ----------------------------
-- Table structure for Accounts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Accounts]') AND type IN ('U'))
	DROP TABLE [dbo].[Accounts]
GO

CREATE TABLE [dbo].[Accounts] (
  [Id] uniqueidentifier  NOT NULL,
  [Avatar] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'avatar-default.png' NULL,
  [UserId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [UserName] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedUserName] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Email] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedEmail] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [EmailConfirmed] bit  NOT NULL,
  [PasswordHash] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [SecurityStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ConcurrencyStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PhoneNumber] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PhoneNumberConfirmed] bit  NOT NULL,
  [TwoFactorEnabled] bit  NOT NULL,
  [LockoutEnd] datetimeoffset(7)  NULL,
  [LockoutEnabled] bit  NOT NULL,
  [AccessFailedCount] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Accounts] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Accounts
-- ----------------------------
INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'kha.jpg', N'8A820ADB-93D7-4C6F-9404-BDBFC14419F4', N'khab2012213@student.ctu.edu.vn', N'KHAB2012213@STUDENT.CTU.EDU.VN', N'kha@gmail.com', N'KHAB2012213@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAENGjd9vWcx7eskGUInfV0UCEOb5SSivP+9mGoLs/vZonlBynvkYI7SCYOIbYNq1Acg==', NULL, N'c9b9fd8f-4a58-4f68-ba59-50ab7c6bd493', NULL, N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'nhan.png', N'D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B', N'nhanb2012237@student.ctu.edu.vn', N'NHANB2012237@STUDENT.CTU.EDU.VN', NULL, N'NHANB2012237@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAEMd2ylwI7ngnmkKe3STiSWbn15IZ7shmyJCCJcD01s2+OYbQWLQyP+fOWlejUgsuYw==', NULL, N'f77ae66d-f8eb-4e9f-b853-0fa7698391ad', NULL, N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'372EA575-2536-4076-9BAB-3E3138DE495F', N'admin.jpg', NULL, N'johnminscarslbm@gmail.com', N'JOHNMINSCARSLBM@GMAIL.COM', N'johnminscarslbm@gmail.com', N'JOHNMINSCARSLBM@GMAIL.COM', N'0', N'AQAAAAEAACcQAAAAEAfpOLDIZ/FeEQxutV5fxPTndqtJNCBHPPtt6EGVDKW0xMrwXCdD7BWR5ysa2zocSA==', NULL, N'340e1db4-051c-4815-b19d-d4fc310efeb9', N'0123456789', N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'the.png', N'F7AA67C1-B3CB-4CCE-9394-1630407343BF', N'theb2003923@student.ctu.edu.vn', N'THEB2003923@STUDENT.CTU.EDU.VN', N'the@gmail.com', N'THEB2003923@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAEIisHHSh7bL3SzQgPwnufS9x56i4dsZJ8RRhZTCBnQlnhLkGxepaRaTCxOp36go7GQ==', NULL, N'121618c5-4f65-4e67-ae10-0c6eda8564d1', NULL, N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5BB18865-B42E-4EF0-844F-9AC649AB1732', N'linh.png', N'1B1BC693-F841-4B2D-9567-63710DA34F1D', N'linhb2012223@student.ctu.edu.vn', N'LINHB2012223@STUDENT.CTU.EDU.VN', NULL, N'LINHB2012223@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAEN1GQnc+k1+tgYkK7Do6VWh1VsIj232GGLcDY0jLmtrqyqPqb5cdYB+lborFK6KnzA==', NULL, N'e9fec500-8b3a-4754-9a45-b5e8f9627634', NULL, N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'lam.jpg', N'BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C', N'lamb1809363@student.ctu.edu.vn', N'LAMB1809363@STUDENT.CTU.EDU.VN', N'lam@gmail.com', N'LAMB1809363@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAEOXWcwFZCXCMr56o6tI1JTOmK9LrSz2ZnBG2zJ8KX1V36rOlae9sNlZojsojqR30Zw==', NULL, N'f02526db-22dc-4bc1-a8e7-1a5afeb63f2b', NULL, N'0', N'0', NULL, N'0', N'0')
GO

INSERT INTO [dbo].[Accounts] ([Id], [Avatar], [UserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'yen.png', N'B03DE8D3-DFD7-4A25-B081-20FB1696DB22', N'nhungb1914237@student.ctu.edu.vn', N'NHUNGB1914237@STUDENT.CTU.EDU.VN', NULL, N'NHUNGB1914237@STUDENT.CTU.EDU.VN', N'0', N'AQAAAAEAACcQAAAAEH6GrrC59MwnaWemhvUukY+jGKBNsBE1CTyj+BbaFN5uZHDu/uIqUR3gZnk8BdqpsQ==', NULL, N'c5d0780c-7ab8-4c16-97e9-e9a062c62636', NULL, N'0', N'0', NULL, N'0', N'0')
GO


-- ----------------------------
-- Table structure for Authors
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Authors]') AND type IN ('U'))
	DROP TABLE [dbo].[Authors]
GO

CREATE TABLE [dbo].[Authors] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Authors] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Authors
-- ----------------------------
INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A001', N'Đặng Hoàng Giang')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A002', N'Higashino Keigo')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A003', N'TS. Nguyễn Công Danh')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A004', N'PGS. TS. Trần Cao Đệ')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A005', N'PGS. TS. Huỳnh Xuân Hiệp')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A006', N'TS. Phan Phương Lan')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A007', N'Christian Wenz')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A008', N'Valerio De Sanctis')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A009', N'Adam Freeman ')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A010', N'Arnaud Lauret ')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A011', N'JJ Geewax')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A012', N'Alan Dennis ')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A013', N'Barbara Wixom')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A014', N'Roberta M. Roth')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A015', N'Hoàng Phê')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A016', N'Yuval Noah Harari')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A017', N'Hideko Suzuki')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A018', N'Trần Văn Chánh')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A019', N'Andrew H. Knoll')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A020', N'David A. Phillips')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A021', N'Đoàn Giỏi')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A022', N'Nariko Narita')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A20240504003533', N'Lee Minh kha')
GO

INSERT INTO [dbo].[Authors] ([Id], [Name]) VALUES (N'A20240504003745', N'Tung Lam')
GO


-- ----------------------------
-- Table structure for Blogs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Blogs]') AND type IN ('U'))
	DROP TABLE [dbo].[Blogs]
GO

CREATE TABLE [dbo].[Blogs] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [UserAccountId] uniqueidentifier  NOT NULL,
  [Title] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Image] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Content] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedDate] datetime2(7) DEFAULT '2024-05-09T22:42:03.7208726+07:00' NULL,
  [PostedDate] datetime2(7)  NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NULL,
  [Status] int DEFAULT 1 NOT NULL,
  [TopicId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL
)
GO

ALTER TABLE [dbo].[Blogs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Blogs
-- ----------------------------
INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240426130348', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Test case là gì? Cách viết Test case hiệu quả', N'', N'<p><strong>Test case</strong>&nbsp;là một tài liệu quan trọng trong&nbsp;<strong>kiểm thử phần mềm</strong>&nbsp;nói riêng và quá trình phát triển dự án phần mềm nói chung. Việc&nbsp;<strong>viết test case hiệu quả</strong>&nbsp;sẽ giúp tăng tính ổn định và độ tin cậy của phần mềm, quyết định trực tiếp đến sự thành công của dự án. Trong bài viết hôm nay, chúng ta cùng nhau tìm hiểu xem&nbsp;<strong>Test case là gì</strong>&nbsp;và&nbsp;<strong>cách để viết được một test case hiệu quả</strong>&nbsp;nhé.</p><h2>Test case là gì?</h2><p>Test case – trường hợp kiểm thử là một tài liệu tập hợp các hành động được thực thi để kiểm tra, xác minh xem một chức năng của phần mềm có hoạt động chính xác với yêu cầu hay không. Một test case sẽ mô tả quá trình dữ liệu đầu vào (input), các hành động(action) hay sự kiện(event) thực hiện một cách tuần tự và kết quả mong đợi (expected result).</p><p><br></p>', N'2024-04-26 13:03:48.9236096', N'2024-04-26 13:04:20.9972782', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240430214436', N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'4 câu hỏi hay gặp trong một buổi phỏng vấn và cách trả lời', N'', N'<p>Test thui</p>', N'2024-04-30 21:44:36.5105208', N'2024-04-30 21:45:01.5548932', N'0', N'2', N'D2AB6BB4-0A82-4D2C-B70E-03DD1C3BE23D')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240430230453', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'Nên học Front-end hay Back-end trước?', N'', N'<p>Đây là câu hỏi mà nhiều bạn khi mới bắt đầu học&nbsp;<a href="https://topdev.vn/blog/lap-trinh-web-nen-hoc-ngon-ngu-nao/" rel="noopener noreferrer" target="_blank"><strong>lập trình Web</strong></a>&nbsp;đặt ra và phân vân không biết lựa chọn nào là phù hợp với bản thân cũng như nhu cầu của thị trường tuyển dụng. Bài viết hôm nay chúng ta cùng nhau đi trả lời cho câu hỏi trên nhé.</p><p><br></p><h2>Trước tiên chúng ta cần hiểu&nbsp;<strong>Front-end</strong>&nbsp;và&nbsp;<strong>Back-end</strong>&nbsp;là gì?</h2><p>Back-end cũng là phần mà người dùng không nhìn thấy được như Front-end, hay như chúng ta vẫn hay ví von đấy là phần chìm của tảng băng trôi. Có sự khác biệt rõ ràng giữa ứng dụng tạo ra ở 2 phía:</p><ul><li>Ứng dụng Front-end chạy trên trình duyệt (browsers), thực hiện việc hiển thị nội dung dữ liệu và xử lý các tương tác của người dùng.</li><li>Ứng dụng Back-end là ứng dụng chạy ở phía máy chủ (server-side) phục vụ cho mọi yêu cầu được gửi đến từ phía máy khách (client-side).&nbsp;</li></ul><p>Do có sự khác nhau đó và việc tạo ra ứng dụng dành cho Front-end và Back-end là khác nhau, đòi hỏi những ngôn ngữ lập trình và kỹ năng khác nhau.</p><p><br></p><h2>Ngôn ngữ lập trình sử dụng cho Front-end và Back-end</h2><p>Để xây dựng ứng dụng cho phía Front-end, 3 ngôn ngữ cơ bản mà chúng ta cần trang bị là&nbsp;<a href="https://topdev.vn/viec-lam-it/html-kt75" rel="noopener noreferrer" target="_blank">HTML</a>,&nbsp;<a href="https://topdev.vn/viec-lam-it/css-kt3" rel="noopener noreferrer" target="_blank">CSS</a>&nbsp;và&nbsp;<a href="https://topdev.vn/viec-lam-it/javascript-kt22" rel="noopener noreferrer" target="_blank">JavaScript</a>.&nbsp;Khi đã nắm vững được 3 trụ cột trên thì có nhiều các thư viện, framework hỗ trợ lập trình, giúp tổ chức và viết source code tốt hơn như:&nbsp;<a href="https://topdev.vn/viec-lam-it/react-kt7367" rel="noopener noreferrer" target="_blank">React</a>, Vue,&nbsp;<a href="https://topdev.vn/viec-lam-it/angular-kt1480" rel="noopener noreferrer" target="_blank">Angular</a>, Jquery, Bootstrap, …</p><p>Trong khi đó thì đối với Back-end, ứng dụng được chạy ở phía server-side, vì thế có sự đa dạng trong việc lựa chọn ngôn ngữ lập trình cũng như nền tảng hệ điều hành sử dụng. Chúng ta có thể sử dụng Java, Python, JavaScript, PHP, C#,… để xây dựng ứng dụng Back-end. Ngoài ra thì để làm được Back-end, lập trình viên cũng phải trang bị thêm các kiến thức liên quan đến việc giao tiếp với&nbsp;<a href="https://topdev.vn/blog/database-la-gi-cac-kieu-database-pho-bien-va-ung-dung/" rel="noopener noreferrer" target="_blank">Database</a>&nbsp;cũng như các services khác.</p><p><br></p><h2>Nên học Front-end hay Back-end trước?</h2><p>Cụ thể hãy cũng xét một số yếu tố bạn nên cân nhắc để trả lời cho câu hỏi trên nhé:</p><ul><li><strong>Sự yêu thích và đam mê của bạn</strong>: đây là yếu tố sẽ giúp bạn dễ dàng lựa chọn hướng đi và gắn bó một cách lâu dài trong bất kỳ ngành nghề nào.&nbsp;</li><li><strong>Thế mạnh, kỹ năng bạn sẵn có</strong>: làm Front-end sẽ phù hợp với những bạn có chút năng khiếu về&nbsp;<a href="https://topdev.vn/blog/mot-so-nguyen-tac-thiet-ke-ui-ux-website/" rel="noopener noreferrer" target="_blank">UI/UX</a>; ngược lại nếu bạn thích làm việc với dữ liệu, tiếp xúc với cả phần cứng nếu cần thì Back-end sẽ là một lựa chọn tốt hơn.</li><li><strong>Mức độ phức tạp</strong>: nói một cách công bằng thì làm Back-end vẫn sẽ phức tạp, đòi hỏi khả năng logic cũng như yêu cầu tư duy tốt hơn so với làm Front-end. Lập trình viên Back-end cũng sẽ đòi hỏi số năm kinh nghiệm cao hơn để có thể hiểu sâu về hệ thống và xây dựng, lựa chọn công nghệ, dịch vụ phù hợp.</li><li><strong>Cơ hội việc làm</strong>: Front-end dựa trên nền tảng 3 ngôn ngữ chính là HTML, CSS và JavaScript, cũng vì thế mà bạn có nhiều cơ hội tuyển dụng hơn. Back-end yêu cầu một ngôn ngữ lập trình cụ thể; cũng vì thế mà sẽ khá khó khăn nếu bạn có ý định chuyển đổi môi trường và nền tảng.</li></ul><p><br></p><h2>Xu hướng trở thành một Fullstack Developer</h2><p>Front-end và Back-end luôn phải đi cùng với nhau và không thể thiếu để xây dựng lên một hệ thống Website; vì thế xu hướng hiện nay là trở thành một Fullstack Dev với khả năng làm ở cả 2 phía. Đầu tư học cả HTML, CSS, JavaScript cùng một ngôn ngữ Back-end viết ứng dụng server rõ ràng sẽ tốn thời gian và công sức của chúng ta gấp đôi; nhưng mang lại khả năng làm việc độc lập, đáp ứng nhu cầu tuyển dụng và cơ hội có được mức thu nhập hấp dẫn hơn rất nhiều. Lúc này bạn sẽ không cần phải trả lời câu hỏi nên học gì trước nữa, mà sẽ là việc song song cùng lúc học cả 2 để tự tin làm bất kỳ task nào trong một dự án phát triển Web.</p><p><br></p><h2>Kết bài</h2><p>Câu trả lời cuối cùng dành cho các bạn với câu hỏi từ đầu bài chính là học cái nào trước cũng đều tốt cả và học cả 2 cùng một lúc lại càng tốt hơn.&nbsp;<strong>Front-end hay Back-end&nbsp;</strong>cũng đều đã, đang và sẽ là những vị trí không thể thiếu trong team phát triển dự án; vì thế đừng ngần ngại lựa chọn một hướng theo ý muốn của bản thân và bắt đầu học ngay từ bây giờ. Chúc các bạn sớm lựa chọn được con đường của bản thân trên hành trình trở thành một lập trình viên; hẹn gặp lại trong các bài viết tiếp theo của mình.</p><p><br></p>', N'2024-04-30 23:04:53.0506148', N'2024-04-30 23:05:02.1822226', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240430231304', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Học back end cần học những gì? Cho người mới bắt đầu', N'', N'<h2>1.&nbsp;<strong>Programming Languages</strong></h2><p>Dưới đây là 3 ngôn ngữ thường được sử dụng cho backend:</p><ul><li><strong>Java:</strong>&nbsp;Đây là ngôn ngữ mà nhiều anh em thường nhầm với&nbsp;<a href="https://topdev.vn/viec-lam-it/javascript-kt22" rel="noopener noreferrer" target="_blank">JavaScript</a>. Tuy nhiên, Java và Javascript là khác nahu. Java thường sử dụng để tạo ra hệ thống mạnh mẽ. Mức độ phổ biến cao, chính vì vậy đây là ngôn ngữ cần thiết cho anh em developer.</li><li><strong>PHP:</strong>&nbsp;Về phía web, ngôn ngữ thường hay sử dụng là&nbsp;<a href="https://topdev.vn/viec-lam-it/php-kt1" rel="noopener noreferrer" target="_blank">PHP</a>. Một số trang web đang được phát triển bằng php, vừa là mã nguồn mở mà còn free. Vì vậy, kỹ năng PHP cũng là kỹ năng mà anh em backend cần có.</li><li><strong>Python:</strong>&nbsp;Với sự phát triển vượt bậc của AI, ML thì&nbsp;<a href="https://topdev.vn/viec-lam-it/python-kt34" rel="noopener noreferrer" target="_blank">Python</a>&nbsp;cũng trở thành ngôn ngữ backend cần phải biết. Đây là một trong những ngôn ngữ hàng đầu, muốn dùng cho cái đơn giản cũng ok mà dùng cho cái phức tạp cũng ok. Mấy ứng dụng phổ biến như Spotify và Dropbox cũng được viết bằng Python.</li></ul><p>Viết tới đây chắc sẽ có một số anh em thắc mắc về&nbsp;<a href="https://topdev.vn/viec-lam-it/nodejs-kt36" rel="noopener noreferrer" target="_blank">Nodejs</a>, tất nhiên Nodejs cũng là ngôn ngữ backend đáng để học. Ngôn ngữ nào cũng có cái hay và phía trên chỉ là ví dụ 3 ngôn ngữ. Còn lại anh em muốn tiếp cận ngôn ngữ nào trước cũng được.Chỉ cần chọn cho mình 1 ngôn ngữ, vẽ ra roadmap cụ thể là anh em có thể bắt đầu trên con đường trở thành master 1 ngôn ngữ phía Backend rồi.</p><p><br></p><h2>2. Frameworks</h2><p>Sau khi đã có kiến thức về ngôn ngữ lập trình, anh em sẽ hiểu khi cần xây dựng một cái gì đó to lớn, chỉ với ngôn ngữ sẽ khó khăn như thế nào. Ví như anh em xây cả lâu đài, mà từng cái bai, cục gạch anh em cũng phải tự làm, mày mò từng chút một. Vậy lúc nào mới xong?</p><p>Chính lúc này ta cần với frameworks.</p><p>Một số framework phổ biến anh em có thể tham khảo bao gồm:</p><ul><li><a href="https://topdev.vn/blog/ruby-on-rails-la-gi/" rel="noopener noreferrer" target="_blank"><strong>Ruby on Rails</strong></a><strong>:</strong>&nbsp;Một số thứ ở Ruby on Rails giúp nó nổi bật hơn mấy frameworks phái dưới. Ông này base trên nền Ruby, có automated testing, có libraries, nếu làm đa ngôn ngữ có localization. Nó cũng là open-source web app development framework. Tất. nhiên, luôn sử dụng ngôn ngữ Ruby.</li><li><a href="https://topdev.vn/blog/django-la-gi-tat-ca-nhung-dieu-can-biet-ve-framework-nay/" rel="noopener noreferrer" target="_blank"><strong>Django</strong></a><strong>:</strong>&nbsp;Là open-source và một trong những web frameworks tốt nhất viết trên nền ngôn ngữ Python. Rất tốt cho việc mở rộng (scalability) và bảo mật (security). Ngoài ra Django cũng hỗ trợ lập trình bất đồng bộ.</li><li><a href="https://topdev.vn/blog/flask-python-la-gi-nhung-dieu-can-biet/" rel="noopener noreferrer" target="_blank"><strong>Flask</strong></a><strong>:</strong>&nbsp;Cũng base trên nền Python và có thể sử dụng để xây dựng web app framework rất nhanh. Nhiều tính năng chính của Flask bao gồm hỗ trợ WSGI cho phép xây dựng rất nhanh web application.</li><li><a href="https://topdev.vn/blog/uu-nhuoc-diem-cua-expressjs/" rel="noopener noreferrer" target="_blank"><strong>Express</strong></a><strong>:</strong>&nbsp;Là framework nhẹ và nổi tiếng nhất sử dụng ngôn ngữ Node.js. Sử dụng để xây dựng web app framework. Express cho phép phát triển rất nhanh và development side-server cũng khá dễ dàng.</li></ul><p><br></p><h2>3. Database</h2><p>Nếu không có hiểu biết về hệ cơ sở dữ liệu, anh em không thể tự nhận mình là backend developer được. Đơn giản là backend sẽ thường làm việc với&nbsp;<a href="https://topdev.vn/blog/phan-1-gioi-thieu-co-so-du-lieu-csdl-he-quan-tri-csdl/" rel="noopener noreferrer" target="_blank">hệ cơ sở dữ liệu</a>.</p><p>Ở một số hệ thống, database được xem như trái tim, nơi chứa những dự liệu quý giá nhất cần thiết cho hệ thống. Chính vì vậy, để trở thành backend developer, anh em cần có kiến thức tốt ở lĩnh vực database. Kiến thức tốt ở đây có thể được hiểu qua vài ví dụ dưới đây:</p><ul><li>Hiểu về data types, hiểu về structure, hiểu về cách thức DB vận hành</li><li>Tối ưu tốc độ, phân tích query, tìm hiểu lý do query bị chậm</li><li>So sánh ưu nhược điểm các loại database, sự khác nhau giữa SQL và NoSQL</li><li>Thiết kế và vận hành database, hiểu sâu về quản lý database</li></ul><p><br></p><h2>4.&nbsp;<strong>Data Structures và Algorithms</strong></h2><p>Cấu trúc dữ liệu và thuật toán cũng là thiết yếu với backend developer. Thực thế thì data structure là cần thiết với tất cả các kĩ sư phần mềm. Nhưng đối với backend, anh em cần thật sự hiểu sâu về&nbsp;<a href="https://topdev.vn/blog/ung-dung-thuat-toan-va-cau-truc-du-lieu-luc-di-lam/" rel="noopener noreferrer" target="_blank">Data structures và Algorithms</a>&nbsp;(thuật toán).</p><p>Một số loại cấu trúc dữ liệu phổ biến có thể liệt kê dưới đây:</p><ul><li><a href="https://topdev.vn/blog/su-khac-biet-giua-list-of-va-arrays-aslist-la-gi/" rel="noopener noreferrer" target="_blank">Arrays</a></li><li>Linked Lists</li><li>Stacks</li><li>Queues</li><li>Graphs</li><li>Hash Tables</li><li>Binary Search Tree</li></ul><p>Hiểu về cấu trúc dữ liệu là hiểu về cách nó hoạt động. Về performance, về độ phức tạp (complexity) là bao nhiêu. Lúc nào thì dùng loại data structure này, lúc nào thì dùng data structure kia. Chứ không chỉ đơn thuần là nhớ tên rồi muốn dùng sao thì dùng nha anh em.</p><ul><li>Sau khi đã nắm chắc Data Structure thì về thuật toán, anh em cần hiểu cơ bản về các thuật toán kinh điển. Hiểu ở đây là hiểu rõ cách thức hoạt động, ưu, nhược điểm. Còn lại implement thì thường đã có rất nhiều người làm rồi. Anh em chỉ nhớ sử dụng cho đúng lúc, đúng địa điểm là được.Recursion</li><li>Bubble sort</li><li>Selection sort</li><li>Binary Search</li><li>Insertion Sort</li><li>Databases and Cache</li></ul><p><br></p><h2>5. API, REST, GraphQL</h2><p>Anh em luôn thấy là backend với frontend đi liền một cặp, nếu chỉ có backend thì application không thể hoạt động. Tương tự vậy, nếu chỉ frontend thì ứng dụng cũng không thể hoàn thành.</p><p>Vậy backend và frontend giao tiếp với nhau như thế nào? Tất nhiên là thông qua API, vậy API có phải là yếu tố bắt buộc và backend developer cần biết không?</p><p>Câu trả lời là có, 100% các lập trình viên backend đều biết rõ về&nbsp;<a href="https://topdev.vn/blog/api-la-gi-cac-nguyen-tac-xay-dung-rest-api/" rel="noopener noreferrer" target="_blank">API</a>&nbsp;và REST. REST có bao nhiêu method, các method đó sử dụng làm gì? Thiết kế API như thế nào là tốt. Song song với đó, anh em cũng cần có kiến thức và tìm hiểu thêm về&nbsp;<a href="https://topdev.vn/blog/gioi-thieu-ve-json-binding-trong-jakarta-ee/" rel="noopener noreferrer" target="_blank">JSON</a>, XML. Các phương thức giao tiếp với client.</p><p><br></p><h2>6. Devops và Server</h2><p>Để backend có thể hoạt động, tất nhiên không thể thiếu server. Vậy anh em cần tìm hiểu thêm về các loại server,&nbsp;<a href="https://topdev.vn/blog/su-khac-biet-giua-windows-va-linux-cuoc-chien-khoc-liet/" rel="noopener noreferrer" target="_blank">Windows thì khác gì Linux?</a>&nbsp;Services mình viết lên sẽ chạy ở đâu, chạy như thế nào? Cấu hình 1 máy như thế nào là đủ.</p><p>Sau khi đã hiểu về server. Vậy giờ cần hiểu thêm về&nbsp;<a href="https://topdev.vn/blog/ci-cd-la-gi-loi-ich-su-dung-trong-quy-trinh-phat-trien-phan-mem/" rel="noopener noreferrer" target="_blank">CI,CD</a>. Hai cái này khác nhau như thế nào? Để triển khai auto deployment ta cần những gì. Tất tần tật những kiến thức đó là kiến thức bắt buộc với backend developer. Các môi trường development, staging và production khác gì nhau? Tại sao ta lại cần những môi trường này?</p><p>Ngoài ra khi tìm hiểu sâu hơn, anh em sẽ cần biết thêm về quản lý version. Kỹ năng điều tra, giải quyết vấn đề. Xử lý sự cố trong trường hợp production down.</p><p><br></p>', N'2024-04-30 23:13:04.2934928', N'2024-04-30 23:13:12.5862010', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240501223254', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'Chia sẻ kinh nghiệm viết code Front-end hiệu quả và bảo mật', N'', N'<p><strong>Lập trình Front end</strong>&nbsp;bao gồm việc thiết kế ra một giao diện Web, xử lý tương tác với người dùng, gửi nhận yêu cầu với phía Server. Những yêu cầu trên đòi hỏi ngoài những kiến thức cơ bản như&nbsp;<strong>HTML, CSS, JavaScript</strong>&nbsp;thì anh em Dev Frontend cần trang bị thêm nhiều kỹ năng khác cùng kinh nghiệm trong quá trình làm việc để có thể đáp ứng được yêu cầu từ dự án và khách hàng.</p><p>Bài viết hôm nay mình sẽ&nbsp;<strong>chia sẻ</strong>&nbsp;một số&nbsp;<strong>kinh nghiệm viết code Front end hiệu quả và bảo mật</strong>&nbsp;rút ra từ những dự án đã tham gia cùng việc học hỏi, tìm hiểu thêm từ cộng đồng lập trình. Chúng ta cùng bắt đầu nhé!</p><h2>Sử dụng các framework hiện đại</h2><p>Hầu hết các trang Web hiện nay đều được xây dựng bởi các framework hiện đại như React, VueJS, Angular, jQuery,… Các Front end Framework hiện nay đều được xây dựng và phát triển bởi các tổ chức cùng sự support từ cộng đồng lập trình viên uy tín; vì vậy việc lựa chọn sử dụng chúng để phát triển các ứng dụng, sản phẩm, website của bạn mang đến sự yên tâm và hiệu quả.&nbsp;</p><p>Lợi ích đầu tiên khi sử dụng các&nbsp;<a href="https://topdev.vn/blog/lua-chon-framework-frontend-nao-trong-thoi-diem-hien-tai/" rel="noopener noreferrer" target="_blank">framework Front end</a>&nbsp;là việc tối ưu hóa được nguồn lực trong dự án của bạn, khi mà các anh em lập trình viên trong team khả năng cao đã có kiến thức hay hiểu biết nhất định về những thư viện phổ biến đó. Với cấu trúc rõ ràng, các documents chi tiết và sự hỗ trợ từ cộng đồng của từng framework sẽ giúp bạn xây dựng một project hiệu quả, đảm bảo khả năng mở rộng dự án về sau tùy theo mục đích sử dụng.&nbsp;Bên cạnh đó, các framework Frontend hiện đại ngày nay được tích hợp sẵn nhiều công cụ, biện pháp an ninh giúp hỗ trợ bảo mật dành cho Website của bạn.</p><p>Để đảm bảo Website của bạn luôn được bảo vệ, nâng cấp bảo mật một cách tối ưu từ các công nghệ của framework tích hợp sẵn thì hãy thường xuyên thực hiện cập nhật phiên bản mới nhất của framework đó.</p><h2>Tận dụng các thư viện có sẵn</h2><p>Một trong những lợi thế của lập trình viên hiện nay là có rất nhiều thư viện có sẵn hỗ trợ bạn trong quá trình viết code, lập trình từ xây dựng giao diện đến xử lý chức năng. Làm Front end thì không thể không sử dụng&nbsp;<a href="https://topdev.vn/blog/6-cau-lenh-npm-huu-ich/" rel="noopener noreferrer" target="_blank">NPM</a>&nbsp;– Node Package Manager – một công cụ tạo và quản lý các thư viện lập trình JavaScript. Trên đây có hàm trăm nghìn các thư viện với các đoạn code có sẵn thực hiện một chức năng nào đó. Bạn sẽ tiết kiệm được rất nhiều thời gian, công sức cũng như đem lại sự hiệu quả trong quá trình phát triển dự án của mình.</p><p>Và nếu bạn tạo ra được những đoạn code xử lý hay, những thành phần giao diện mới lạ hoặc chỉ đơn giản là bạn có ý định chia sẻ, sử dụng lại code của mình trong tương lai; bạn cũng có thể tạo một thư viện của bản thân trên NPM. Điều này sẽ giúp bạn tăng khả năng viết code của mình, đồng thời cộng đồng lập trình hoàn toàn có thể góp ý cho những dòng code mà bạn viết ra; từ đó đưa ra những cải thiện cho chính những đoạn code đó.</p><h2>Áp dụng các best practices cải thiện code</h2><p>Best practices là những kiến thức được rút ra dựa theo kinh nghiệm của những người đi trước trong ngành mà mỗi lập trình viên chúng ta đều nên biết và làm theo. Thông thường sẽ không có một document nào có thể mô tả chi tiết những kinh nghiệm trên mà nó chỉ được thể hiện cụ thể thông qua source code, giải quyết những case study mà thực tế dự án gặp phải.&nbsp;</p><p>Đối với Front end, các bạn có thể dễ dàng tìm kiếm, đọc và tìm hiểu các JavaScript best practices, thông thường được các lập trình viên có kinh nghiệm chia sẻ source code một cách công khai (public) thông qua GitHub. Học hỏi được qua những best practices sẽ giúp bạn có thêm kinh nghiệm lập trình, viết code hiệu quả và bảo mật hơn trong dự án của mình.</p><h2>Thiết lập các kỹ thuật bảo mật</h2><p>Các ứng dụng Front end hiện nay cho phép người dùng có thể thao tác, tương tác nhiều hơn; có nhiều chức năng phức tạp và thường xuyên truy vấn, cập nhật dữ liệu cá nhân hơn. Điều này cũng trở thành thách thức khi viết code Frontend, phải đảm bảo hiệu năng ứng dụng, đồng thời cũng cần đảm bảo sự an toàn dữ liệu cho khách hàng.&nbsp;</p><p>Để thực hiện được yêu cầu trên thì một lập trình viên Front end cũng cần tìm hiểu, nắm được các cách thức tấn công vào Website, cách mà thông tin, dữ liệu có thể bị đánh cắp, rò rỉ; từ đó viết ra những dòng code đảm bảo sự an toàn khi phát triển ứng dụng. Một số lưu ý sau đây có thể giúp bạn:</p><ul><li>Tránh/ Hạn chế sử dụng innerHTML ngăn việc chèn mã JavaScript thực thi hành động không được phép trên trang</li><li>Thực hiện encode dữ liệu đầu ra giúp tránh các lỗi XSS, đồng thời bảo mật dữ liệu người dùng cuối khi gửi các thông tin cá nhân.</li><li>Sử dụng mode “X-XSS-Protection”: “1; mode = block” giúp chặn phản hồi từ các đoạn mã JavaScript bị tiêm vào từ đầu bởi người dùng</li><li>Thiết lập CSP (Content Security Policy) – Chính sách bảo mật nội dung để xác định các nguồn tải về an toàn trên trang.</li><li>Disable iframe embedding bằng thiết lập “X-Frame-Options”: “DENY” giúp ngăn chặn tấn công clickjacking</li><li>Thiết lập “Referrer-Policy”: “no-referrer” ngăn việc điều hướng sang trang khác đi kèm thông tin chứa dữ liệu nhạy cảm.</li></ul><h2>Kết bài</h2><p>Trên đây là một vài&nbsp;<strong>kinh nghiệm</strong>&nbsp;mình tích lũy được và chia sẻ dành cho các bạn lập trình khi&nbsp;<strong>viết code Front end</strong>. Cải thiện source code do mình viết ra, làm nó trở nên&nbsp;<strong>hiệu quả và bảo mật</strong>&nbsp;hơn sẽ giúp ích rất nhiều cho dự án mà bạn tham gia. Tích lũy được kinh nghiệm đồng thời cũng sẽ giúp bạn đi nhanh hơn trong con đường sự nghiệp làm lập trình viên của bản thân. Hy vọng bài viết hữu ích dành cho bạn và hẹn gặp lại trong các bài viết tiếp theo của mình.</p><p><br></p>', N'2024-05-01 22:32:54.1414173', N'2024-05-01 22:33:24.6700719', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240501223554', N'5BB18865-B42E-4EF0-844F-9AC649AB1732', N'Chuẩn bị gì trước buổi phỏng vấn vị trí lập trình viên Frontend', N'', N'<p>Với sự tăng trưởng của các công ty công nghệ hiện nay, nhu cầu&nbsp;<strong>tuyển dụng lập trình viên</strong>&nbsp;đang là rất cao. Trong đó&nbsp;<a href="https://topdev.vn/blog/frontend-developer-la-gi/" rel="noopener noreferrer" target="_blank"><strong>lập trình viên Frontend</strong></a>&nbsp;luôn là vị trí có số lượng yêu cầu cao hơn do đặc thù của dự án cùng với sự phát triển của ứng dụng Web. Để có thể chuẩn bị thật tốt và thể hiện đúng kỳ vọng của nhà tuyển dụng, hôm nay mình cùng chia sẻ với các bạn một vài&nbsp;<strong>kinh nghiệm cho buổi phỏng vấn lập trình viên Frontend</strong>&nbsp;nhé.</p><h2>Chuẩn bị trước buổi phỏng vấn</h2><p>Trước hết để có được sự tự tin khi tham gia phỏng vấn, bạn cần chuẩn bị đầy đủ từ trang phục, tác phong, chú ý giờ giấc,… để có thể tạo ấn tượng tốt với nhà tuyển dụng. Nắm chắc được quy trình phỏng vấn thông qua nội dung mà phía HR đã thông báo.</p><p><br></p><p>Bạn cũng cần phải tìm hiểu về công ty ứng tuyển, điều này không chỉ giúp các bạn tạo được ấn tượng tốt với nhà tuyển dụng mà đồng thời cũng có thể biết được về lĩnh vực, chuyên môn hay các dự án mà doanh nghiệp, tổ chức đang phát triển để từ đó phản hồi lại trong buổi phỏng vấn. Bạn sẽ thường gặp những câu hỏi về công ty như bạn biết công ty qua kênh nào, bạn biết gì về công ty và sản phẩm mà công ty đang phát triển, tại sao bạn lựa chọn công ty để ứng tuyển,…</p><p>Ngoài ra, hãy suy nghĩ và chuẩn bị trước về những câu hỏi mà nhà tuyển dụng sẽ hỏi bạn, nhất là về&nbsp;<a href="https://topdev.vn/blog/7-bi-kip-deal-muc-luong-thuong-luong/" rel="noopener noreferrer" target="_blank">mức lương</a>&nbsp;mong muốn. Xem xét những yếu tố về&nbsp;<a href="https://topdev.vn/blog/tong-quan-muc-luong-lap-trinh-vien-viet-nam-2023/" rel="noopener noreferrer" target="_blank">mức lương trung bình của thị trường</a>, từ đó đối chiếu với bản thân theo kỹ năng chuyên môn, kinh nghiệm làm việc; bạn sẽ đưa ra được mức mà bạn hy vọng nhà tuyển dụng sẽ chấp nhận bạn.</p><p><br></p><h2>Trong buổi phỏng vấn</h2><p>Một buổi phỏng vấn vị trí lập trình viên Frontend, nhà tuyển dụng sẽ hỏi những kiến thức chuyên môn về vị trí mà bạn đang ứng tuyển. Tùy vào level (<a href="https://topdev.vn/blog/fresher-junior-senior-la-gi/" rel="noopener noreferrer" target="_blank">Fresher, Junior, Senior</a>) mà sẽ có những phần câu hỏi tương ứng, thông thường sẽ bao gồm 3 phần:</p><h3>1.&nbsp;Kiến thức cơ bản về Frontend: sẽ bao gồm HTML, CSS và JavaScript</h3><p><a href="https://topdev.vn/blog/javascript-la-gi-javascript-developer/" rel="noopener noreferrer" target="_blank">JavaScript</a>&nbsp;là ngôn ngữ lập trình được phát triển để tạo ra các tương tác trên trang Web bằng việc xử lý nạp, hiển thị dữ liệu thông qua việc gọi yêu cầu đến server; nhận và xử lý các hành động đến từ người dùng và trả ra các kết quả tương ứng.</p><p>HTML, CSS và JavaScript là 3 nền tảng cơ bản mà mọi lập trình viên Frontend đều nắm vững, cũng vì thế mà nhà tuyển dụng sẽ có thể hỏi bạn bất cứ câu hỏi nào liên quan đến 3 ngôn ngữ này. Kinh nghiệm ở đây dành cho bạn là hãy lướt qua một lượt các kiến thức cơ bản về 3 ngôn ngữ này vì có nhiều thứ tưởng chừng dễ nhưng nếu bạn không thường xuyên làm, thực hành sẽ khiến bạn có thể quên mất.</p><p><br></p><h3>2. Kiến thức về nền tảng thư viện, Framework theo vị trí tuyển dụng như React, VueJS, Angular,…</h3><p>Trong mô tả công việc tất nhiên sẽ ghi rõ yêu cầu bạn cần có kiến thức hay kinh nghiệm trong một nền tảng thư viện, framework mà nhà tuyển dụng yêu cầu. Đây là những bộ công cụ chứa cả phần HTML, CSS và source code viết bằng JavaScript được phát triển và sử dụng rộng rãi.</p><p><br></p><p>Bạn cần chuẩn bị trước kiến thức về phần này vì nó sẽ là trọng tâm của buổi phỏng vấn chuyên môn, các vấn đề sẽ được bên người hỏi đưa ra và bạn cần trả lời một cách ngắn gọn và vẫn đủ sức thuyết phục nhà tuyển dụng rằng mình nắm bắt được vấn đề. Mỗi một thư viện, framework sẽ có những đặc trưng riêng của mình; các câu hỏi chủ yếu sẽ xoay quanh những vấn đề như sau:</p><ul><li><strong>Fundamentals hay core concepts</strong>: những nguyên tắc cơ bản, khái niệm cốt lõi của nền tảng</li><li><strong>Life Cycle</strong>: vòng đời của một phần tử, một function hay một màn hình mà nền tảng đó mô tả và xử lý. Yếu tố này cũng thường đi cùng với việc quản lý các trạng thái dữ liệu trong ứng dụng (state management)</li><li><strong>Advanced hay Patterns</strong>: những phần kiến thức nâng cao, hay những mẫu thường được khuyến khích sử dụng khi viết code và lập trình liên quan đến nền tảng đó.</li></ul><h3>3. Kinh nghiệm làm việc trong các dự án đã tham gia</h3><p>Đây là một yếu tố rất quan trọng có thể quyết định việc nhà tuyển dụng có lựa chọn bạn hay không.&nbsp;<a href="https://topdev.vn/blog/kinh-nghiem-lam-viec-duoc-tinh-nhu-the-nao/" rel="noopener noreferrer" target="_blank">Kinh nghiệm làm việc</a>&nbsp;thường sẽ được mô tả trong CV của bạn, bao gồm những dự án mà bạn đã tham gia, công nghệ được sử dụng trong dự án đó cũng như vai trò của bạn trong team phát triển.</p><p><br></p><p>Đối với riêng lập trình viên Frontend, bạn có thể được hỏi về những kinh nghiệm xử lý&nbsp;<a href="https://topdev.vn/viec-lam-it/uiux-kt8611" rel="noopener noreferrer" target="_blank">UI/UX</a>&nbsp;mà bạn tâm đắc; nó giúp nhà tuyển dụng đánh giá được khả năng sáng tạo và mức độ trải nghiệm trên nhiều sản phẩm khác nhau của bạn. Vì vậy hãy chuẩn bị trước một số kiến thức liên quan đến thiết kế; các kỹ thuật xử lý đa màn hình (responsive), hay có thể là những kiến thức liên quan đến&nbsp;<a href="https://topdev.vn/blog/ky-thuat-seo-bang-urls/" rel="noopener noreferrer" target="_blank">SEO</a>, Optimize,…&nbsp;</p><h2>Sau buổi phỏng vấn</h2><p>Thông thường các bạn sau khi phỏng vấn xong thì thường nghĩ là đã xong việc và chờ kết quả. Trường hợp bạn đã pass phỏng vấn thì tất nhiên là sẽ nhận được một email offer từ nhà tuyển dụng. Tuy vậy một số công ty hay tổ chức có thể không thông báo kết quả trong trường hợp bạn không đáp ứng được yêu cầu tuyển dụng của họ. Trong những trường hợp nhận được kết quả không pass (fail) phỏng vấn hay không nhận được kết quả sau buổi phỏng vấn thì bạn cũng vẫn nên có một email cảm ơn hồi đáp lại cho công ty.</p><p>Một email cảm ơn dành cho việc đội ngũ tuyển dụng, người phỏng vấn đã dành thời gian cho bạn, quan tâm đến bạn sẽ giúp tăng thiện cảm trong mắt công ty đó và biết đâu sau này bạn có cơ hội để apply lại đúng vị trí trên. Hãy lưu ý rằng bạn không qua phỏng vấn có thể đơn thuần là việc bạn chưa phù hợp với đòi hỏi của vị trí công việc hiện tại mà nhà tuyển dụng cần; và bạn hoàn toàn có những cơ hội cho lần phỏng vấn sắp tới.</p><h2>Kết bài</h2><p>Trên đây là những&nbsp;<strong>kinh nghiệm</strong>&nbsp;khi chuẩn bị tham gia&nbsp;<strong>phỏng vấn vị trí lập trình viên Frontend</strong>&nbsp;mà mình muốn chia sẻ dành cho các bạn. Hy vọng bài viết sẽ giúp ích cho bạn trong buổi phỏng vấn sắp tới, hẹn gặp lại trong các bài viết tiếp theo của mình.</p><p><br></p>', N'2024-05-01 22:35:54.7187973', N'2024-05-01 22:36:02.4927787', N'0', N'2', N'D2AB6BB4-0A82-4D2C-B70E-03DD1C3BE23D')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240502014239', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'Phương pháp đọc sách kỹ thuật cho lập trình viên', N'', N'<p>Bắt đầu nhé!</p><h3><strong>Lựa chọn kỹ sách trước khi đọc</strong></h3><p>Hãy dành thời gian để đọc review, lắng nghe trải nghiệm của những người đã viết ra cuốn sách đó, nếu không có liên hệ gì được với tác giả của cuốn sách bạn hãy lên các&nbsp;diễn đàn,&nbsp;hội nhóm review sách về công nghệ&nbsp;cùng có nhiều gợi ý dành cho bạn đó. Việc làm này sẽ giúp bạn nắm được nội dung khái quát của sách và phần nào xác định được nó có phù hợp với mình hay không.</p><p>Một cách khác cũng hay được sử dụng đó là đọc mục lục của sách hoặc đọc tóm tắt nội dung. Việc làm này sẽ giúp bạn biết qua được cấu trúc của sách và đồng thời phát triển tư duy cho bạn với những từ khóa, lý giải cho từng chương mục. Việc suy nghĩ và đặt ra một số câu hỏi cho một số chương trong mục lục sẽ khiến mình cảm thấy thích thú hơn và mong chờ đến lúc đọc chương đó.</p><p><br></p>', N'2024-05-02 01:42:39.9260157', N'2024-05-02 01:43:19.0502052', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO

INSERT INTO [dbo].[Blogs] ([Id], [UserAccountId], [Title], [Image], [Content], [CreatedDate], [PostedDate], [IsDeleted], [Status], [TopicId]) VALUES (N'BL20240510084029', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Phân biệt Front End và Back End, điểm khác nhau là gì?', N'', N'<p>Nếu bạn là một lập trình viên newbie, có thể bạn sẽ bối rối với các thuật ngữ như Front End và Back End. Đây là 2 thuật ngữ quan trọng trong một website bất cứ ai theo học lập trình web đều phải biết. Tuy nhiên, nhiều người vẫn chưa thực sự hiểu rõ sự khác biệt giữa chúng là gì và nhiệm vụ của từng phần là gì. Trong bài viết này, chúng ta sẽ tìm hiểu sâu hơn về Front End và Back End, cách phân biệt Front End và Back End chi tiết nhất. Cùng theo dõi nhé!</p><p>Phân biệt khái niệm Front End và Back End</p><h3><strong>Front End là gì?</strong></h3><p>Những người chịu trách nhiệm xây dựng, phát triển những thành phần này được gọi là Front End Developer. Họ sẽ sử dụng các công cụ và ngôn ngữ lập trình như&nbsp;<a href="https://topdev.vn/blog/html-la-gi/" rel="noopener noreferrer" target="_blank">HTML</a>,&nbsp;<a href="https://topdev.vn/blog/css-la-gi/" rel="noopener noreferrer" target="_blank">CSS</a>,&nbsp;<a href="https://topdev.vn/blog/javascript-la-gi-javascript-developer/" rel="noopener noreferrer" target="_blank">JavaScript</a>&nbsp;để tạo ra giao diện người dùng trực quan và hấp dẫn, tương thích trên nhiều trình duyệt và thiết bị khác nhau.</p><h3><strong>Back End là gì?</strong></h3><p>Các Back End Developer sẽ tập trung vào phía máy chủ trang web bao gồm: Databases, quản lý service,… Sử dụng các ngôn ngữ lập trình như&nbsp;<a href="https://topdev.vn/blog/tong-quan-ve-ngon-ngu-lap-trinh-java/" rel="noopener noreferrer" target="_blank">Java</a>,&nbsp;<a href="https://topdev.vn/blog/python-la-gi/" rel="noopener noreferrer" target="_blank">Python</a>, Ruby,&nbsp;<a href="https://topdev.vn/blog/ngon-ngu-lap-trinh-php-la-gi-tat-tan-tat-nhung-dieu-ban-can-biet-ve-php/" rel="noopener noreferrer" target="_blank">PHP</a>&nbsp;và các framework như Node.js,&nbsp;<a href="https://topdev.vn/blog/ruby-on-rails-la-gi/" rel="noopener noreferrer" target="_blank">Ruby on Rails</a>&nbsp;và Django để phát triển các hệ thống website. Vai trò của một Back End Developer là cực kỳ quan trọng trong việc xây dựng một trang web, bởi vì họ đảm bảo rằng các ứng dụng phải hoạt động chính xác và đáp ứng được nhu cầu của người dùng.</p><p><br></p><h2>Kỹ năng của Front End Developer và Back End Developer</h2><p><strong>Front End Developer</strong>&nbsp;và&nbsp;<strong>Back End Developer</strong>&nbsp;là hai vai trò quan trọng trong quá trình phát triển website. Mỗi vai trò đều có những kỹ năng đặc trưng riêng, dưới đây là một số sự khác biệt về kỹ năng giữa Front End Developer và Back End Developer:</p><h3><strong>Front End Developer</strong></h3><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Thành thạo&nbsp;<strong>HTML, CSS và JavaScript</strong>&nbsp;để xây dựng giao diện người dùng tốt nhất có thể.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>Sử dụng các framework</strong>&nbsp;như&nbsp;<a href="https://topdev.vn/blog/angularjs-la-gi/" rel="noopener noreferrer" target="_blank">Angular</a>,&nbsp;<a href="https://topdev.vn/blog/react-la-gi-lo-trinh/" rel="noopener noreferrer" target="_blank">React</a>,&nbsp;<a href="https://topdev.vn/blog/vue-js-la-gi/" rel="noopener noreferrer" target="_blank">Vue.js</a>, Ember để tăng tốc độ phát triển web.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Kỹ năng&nbsp;<strong>sử dụng JavaScript/jQuery</strong>&nbsp;để thêm các chức năng cần thiết và các plugin, extension&nbsp;giúp việc phát triển trang web nhanh chóng và dễ dàng hơn.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Kỹ năng&nbsp;<strong>quản lý các Git và Version</strong>&nbsp;để theo dõi các thay đổi được tạo ra trong quá trình code hoặc kiểm soát các version.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hiểu biết về&nbsp;<a href="https://topdev.vn/viec-lam-it/uxui-design-kt7" rel="noopener noreferrer" target="_blank"><strong>UI/UX design</strong></a>&nbsp;và các nguyên tắc thiết kế.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Có khả năng sửa lỗi, tối ưu hóa tốc độ tải trang web.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Có kiến ​​thức về&nbsp;<strong>responsive design</strong>&nbsp;và&nbsp;<strong>cross-browser compatibility</strong>.</p><p><br></p><h3><strong>Back End Developer</strong></h3><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Thành thạo các ngôn ngữ lập trình như&nbsp;<a href="https://topdev.vn/viec-lam-it/java-kt21" rel="noopener noreferrer" target="_blank">Java</a>,&nbsp;<a href="https://topdev.vn/viec-lam-it/python-kt34" rel="noopener noreferrer" target="_blank">Python</a>,&nbsp;<a href="https://topdev.vn/viec-lam-it/ruby-kt206" rel="noopener noreferrer" target="_blank">Ruby</a>,&nbsp;<a href="https://topdev.vn/viec-lam-it/php-kt1" rel="noopener noreferrer" target="_blank">PHP</a>, C# để xử lý các yêu cầu phức tạp từ phía người dùng.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Có kiến thức về&nbsp;<strong>cơ sở dữ liệu và truy vấn dữ liệu</strong>, hiện nay SQL và NoSQL là hai loại cơ sở dữ liệu được sử dụng phổ biến nhất.&nbsp;&nbsp;</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hiểu biết về mạng và máy chủ, bao gồm các giao thức web, lưu lượng truy cập, bảo mật và quản lý máy chủ.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Có kiến thức về một số thuật toán như: Depth First Search và Breadth-First Search, bubble sort, selection sort, insertion sort, merge sort, quick sort, thuật toán đệ quy và lặp,…</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Có khả năng&nbsp;<strong>sửa lỗi và cải thiện hiệu suất</strong>&nbsp;website.</p><p>·&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nắm được một số kỹ năng khác như: Quản lý môi trường lưu trữ với CSDL, kiến thức về kiểm soát Git và,…</p><p><br></p><h2>Kết luận</h2><p>Hy vọng bài viết này đã giúp bạn phân biệt được Front End và Back End, cũng như nhiệm vụ và vai trò của 2 vị trí Front End Developer và Back End Developer. Dù là Frontend hay Backend Developer,&nbsp;<strong>cả hai đều có vai trò quan trọng</strong>&nbsp;trong việc phát triển website.</p><p>Nếu bạn muốn trở thành một lập trình viên thành thạo, cần phải nắm vững những kỹ năng và công nghệ cần thiết cho từng vai trò. Với sự phát triển nhanh chóng của ngành công nghệ thông tin hiện nay, việc học tập và cập nhật kiến thức mới liên tục sẽ giúp bạn trở thành một chuyên gia trong lĩnh vực của mình. Chúc bạn thành công!</p><p><br></p>', N'2024-05-10 08:40:29.6754769', N'2024-05-10 08:42:00.4290705', N'0', N'2', N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88')
GO


-- ----------------------------
-- Table structure for BookAuthors
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BookAuthors]') AND type IN ('U'))
	DROP TABLE [dbo].[BookAuthors]
GO

CREATE TABLE [dbo].[BookAuthors] (
  [BookId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [AuthorId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[BookAuthors] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BookAuthors
-- ----------------------------
INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'A20240504003533')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'00000000-0000-0000-0000-000000000000', N'A20240504003745')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'0220B35C-03FE-4507-8383-30BC8D905A28', N'A007')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'0E9B5F1B-0C7B-4093-9559-D3A7FE380832', N'A001')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'14FD5AC3-7C0D-4EFF-A840-E1589D1275EB', N'A012')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'14FD5AC3-7C0D-4EFF-A840-E1589D1275EB', N'A013')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'14FD5AC3-7C0D-4EFF-A840-E1589D1275EB', N'A014')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'1F50773D-4D51-4596-99B6-A624C2F61DDC', N'A008')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'3128D049-F7EC-4275-9BA8-9E10EE4F85EE', N'A005')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'3128D049-F7EC-4275-9BA8-9E10EE4F85EE', N'A006')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'34824C95-72D2-4861-A552-75BAC6F9508F  ', N'A017')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'3ECC8999-CAEA-4C31-9A0E-37FF9158427E', N'A003')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'3ECC8999-CAEA-4C31-9A0E-37FF9158427E', N'A004')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB', N'A015')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'507C99E1-1586-43C1-8831-E7B499C08EE0', N'A016')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'8D573893-12ED-44E5-ABEF-8E0B17695223', N'A009')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'90B5054A-9A37-4249-B1A1-209FFC7AE80D', N'A002')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'A7A7CFF3-5B28-4921-9F06-599A3B14A776', N'A020')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'ABF7E859-5FBA-4C19-B842-B442062C8909', N'A019')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'ADC1F03D-BF8A-48B5-B9EA-4C9F63480566', N'A011')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'AFE53773-D1B3-462D-B27E-8D37C1138639', N'A022')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'B4A8198D-CE3E-49E4-A476-F7F2C4681B0D', N'A021')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'B575681C-AD00-49E9-B85E-82F738439CBF', N'A018')
GO

INSERT INTO [dbo].[BookAuthors] ([BookId], [AuthorId]) VALUES (N'F62EE893-2588-4D12-A22E-E7855E2B9B51', N'A010')
GO


-- ----------------------------
-- Table structure for BookDetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BookDetails]') AND type IN ('U'))
	DROP TABLE [dbo].[BookDetails]
GO

CREATE TABLE [dbo].[BookDetails] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Code] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [PublishedBookId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsAvailable] bit  NOT NULL,
  [IsDeleted] bit  NOT NULL,
  [Status] int  NOT NULL,
  [DueTime] datetime2(7)  NULL,
  [CreatedTime] datetime2(7)  NULL,
  [LastModifiedTime] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[BookDetails] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BookDetails
-- ----------------------------
INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'033CE874-E040-4385-8B9A-140622DDD1A2', N'BD20240410104132', N'B2B4A5F8-C2DB-4199-8C23-1F8C8150E662', N'1', N'0', N'1', N'2024-05-13 15:38:32.7632913', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'1575A9BA-3A5A-4CC9-9787-084DEFBA8B9F', N'BD20240410104487', N'FB51AB25-2788-4B0E-996E-2A68282B2C88', N'1', N'0', N'1', N'2024-05-29 00:14:59.4111796', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'BD20240429155126', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'0', N'0', N'2', N'2024-07-04 21:44:57.6376137', N'1900-01-01 00:00:00.0000000', N'1900-01-01 00:00:00.0000000')
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'BD20240306202612', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'1', N'0', N'1', N'2024-05-22 00:16:22.3205421', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'537D2F89-9938-4AAE-854D-663663BFEA9E', N'BD20240410010876', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'0', N'0', N'3', N'2024-05-21 01:11:10.2179442', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'596A776B-C695-4054-84C9-4309C2AA610E', N'BD20240410104257', N'B2B4A5F8-C2DB-4199-8C23-1F8C8150E662', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'7390FCA1-9278-4797-9778-8A082D0F2BDC', N'BD20240905231425', N'7390FCA1-9278-4797-9778-8A082D0F2BDC', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'75211919-AABC-496A-9BEB-6CF63713E97B', N'BD20240429155424', N'460DCEB3-827D-4B83-8689-3F45F01C20A8', N'0', N'0', N'4', N'2024-05-30 23:03:14.5830295', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'7B22085D-91FF-410C-BA34-778F0F90BAB8', N'BD20240410010945', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'0', N'0', N'4', N'2024-05-30 23:02:01.8723274', N'1900-01-01 00:00:00.0000000', N'1900-01-01 00:00:00.0000000')
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'971C991C-CFAA-4830-8200-2E1F8EB3DB6F', N'BD20240429155424', N'460DCEB3-827D-4B83-8689-3F45F01C20A8', N'1', N'0', N'1', N'2024-05-20 02:51:50.6137491', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'A6C02C01-7A5A-4E9D-A396-33DC1D58EB17', N'BD20240410104423', N'FB51AB25-2788-4B0E-996E-2A68282B2C88', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'AB51F416-3099-4C3C-A545-9D1762EEFC9A', N'BD20240410104154', N'B2B4A5F8-C2DB-4199-8C23-1F8C8150E662', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'B9338DB5-B78A-44AA-A23F-15A781386B24', N'BD20240410104389', N'FB51AB25-2788-4B0E-996E-2A68282B2C88', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'BB76DD0F-4517-45F0-A47E-A7FCC2BEC638', N'BD20240905231532', N'7390FCA1-9278-4797-9778-8A082D0F2BDC', N'1', N'0', N'1', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'da4b76e3-2d86-4f50-ab6e-c93a73d10e0e', N'BD20240306202611', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'1', N'0', N'1', N'2024-05-22 00:16:47.2411639', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'eb7eae5e-c665-4635-aeb0-b05398f9ca87', N'BD20240306202613', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'1', N'0', N'1', N'2024-05-01 00:01:18.8479983', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'EBCC7BD4-C3E6-4569-AC51-5E7482F68938', N'BD20240429155023', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'0', N'0', N'4', N'2024-05-31 08:37:25.9714286', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'F8FD3183-07E7-4E46-8C00-C36A1BA5F796', N'BD20240410010743', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'1', N'0', N'1', N'2024-05-20 02:48:57.1506194', NULL, NULL)
GO

INSERT INTO [dbo].[BookDetails] ([Id], [Code], [PublishedBookId], [IsAvailable], [IsDeleted], [Status], [DueTime], [CreatedTime], [LastModifiedTime]) VALUES (N'FFD578E9-C006-40B5-9F9B-8353EB512AE3', N'BD20240429154935', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'1', N'0', N'1', N'2024-05-20 00:21:37.5569705', NULL, NULL)
GO


-- ----------------------------
-- Table structure for BookRequests
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BookRequests]') AND type IN ('U'))
	DROP TABLE [dbo].[BookRequests]
GO

CREATE TABLE [dbo].[BookRequests] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Code] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [BookDetailId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [UserAccountId] uniqueidentifier  NOT NULL,
  [BookCheckoutId] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] int  NOT NULL,
  [CreatedTime] datetime2(7)  NULL,
  [RejectedTime] datetime2(7)  NULL,
  [ApprovedTime] datetime2(7)  NULL,
  [BorrowedTime] datetime2(7)  NULL,
  [ReceivedTime] datetime2(7)  NULL,
  [DueTime] datetime2(7)  NULL,
  [ReturnedTime] datetime2(7)  NULL,
  [CanceledTime] datetime2(7)  NULL,
  [IsDeleted] bit  NOT NULL,
  [Note] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ExtendedTime] datetime2(7)  NULL,
  [IsExtended] bit DEFAULT CONVERT([bit],(0)) NOT NULL
)
GO

ALTER TABLE [dbo].[BookRequests] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BookRequests
-- ----------------------------
INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'04459b9c-40ec-4780-95fa-2466625e8008', N'BR20240429153033', N'033CE874-E040-4385-8B9A-140622DDD1A2', N'F5AA72EA-A563-4E89-A289-E290814F3C17', NULL, N'5', N'2024-04-29 15:30:33.7879886', NULL, N'2024-04-29 15:38:29.4548379', N'2024-04-29 15:38:32.7630511', N'2024-04-29 15:38:32.7628276', N'2024-05-13 15:38:32.7632713', N'2024-04-29 15:38:35.2045469', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'0d7a3091-6f05-40fd-9055-2f540cc642a9', N'BR20240506013450', N'F8FD3183-07E7-4E46-8C00-C36A1BA5F796', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-04 01:34:50.3472068', NULL, N'2024-05-05 01:55:09.2016788', N'2024-05-06 02:48:57.1501703', N'2024-05-06 02:48:57.1496285', N'2024-05-20 02:48:57.1502511', N'2024-05-06 02:51:06.4394994', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'0ed299d7-4f75-4e33-a419-ec6593d1dc41', N'BR20240410142739', N'1575A9BA-3A5A-4CC9-9787-084DEFBA8B9F', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'7', N'2024-04-10 14:27:39.9623475', NULL, NULL, NULL, NULL, NULL, NULL, N'2024-04-16 14:59:58.7974029', N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'163cc461-9c31-4966-a1b5-c055fab4d1a7', N'BR20240430010755', N'75211919-AABC-496A-9BEB-6CF63713E97B', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-04-30 01:07:55.4977409', NULL, N'2024-04-30 22:57:47.4917138', N'2024-04-30 22:57:51.1262769', N'2024-04-30 22:57:51.1259587', N'2024-05-21 22:57:51.1264263', N'2024-05-06 00:30:00.0992619', NULL, N'0', NULL, N'2024-04-30 22:59:41.1962050', N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'20d7e536-10bc-43dd-844e-65d3021fdd64', N'BR20240507002012', N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-07 00:20:12.1452103', NULL, N'2024-05-07 00:22:40.2977778', N'2024-05-07 23:11:23.5194706', N'2024-05-07 23:11:23.5194270', N'2024-05-21 23:11:23.5194982', N'2024-05-07 23:11:43.5829188', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'2944d183-41ae-4a47-a4e7-0bb0df989689', N'BR20240509212816', N'7B22085D-91FF-410C-BA34-778F0F90BAB8', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'4', N'2024-05-09 21:28:16.0933819', NULL, N'2024-05-09 23:01:47.5474615', N'2024-05-09 23:02:01.8722510', N'2024-05-09 23:02:01.8720367', N'2024-05-30 23:02:01.8723242', NULL, NULL, N'0', NULL, N'2024-05-09 23:02:21.9313065', N'1')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'30f0d82a-695d-4965-8518-15747ee6b9bf', N'BR20240508124720', N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'6', N'2024-05-08 12:47:20.3829036', N'2024-05-09 16:19:37.0247354', N'2024-05-08 13:51:21.5515949', NULL, NULL, N'2024-05-09 13:51:21.5518449', NULL, NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'39974953-14a1-4be6-a67c-3ca0226d6c83', N'BR20240509161052', N'537D2F89-9938-4AAE-854D-663663BFEA9E', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'6', N'2024-05-08 16:10:52.8362270', N'2024-05-09 16:17:50.9564486', N'2024-05-08 16:12:54.5942479', NULL, NULL, N'2024-05-09 16:12:54.5944451', NULL, NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'4b72cf9e-3995-4d5f-884a-35d37b32df14', N'BR20240502015102', N'7B22085D-91FF-410C-BA34-778F0F90BAB8', N'5BB18865-B42E-4EF0-844F-9AC649AB1732', NULL, N'5', N'2024-05-02 01:51:02.1443230', NULL, N'2024-05-04 02:14:14.8283663', N'2024-05-05 15:00:10.1591151', N'2024-05-05 15:00:10.1588763', N'2024-05-19 15:00:10.1592928', N'2024-05-06 02:49:16.1972055', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'51e079eb-f029-4768-9355-d22e2be1860a', N'BR20240502012425', N'FFD578E9-C006-40B5-9F9B-8353EB512AE3', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', NULL, N'5', N'2024-05-02 01:24:25.7768133', NULL, N'2024-05-02 01:24:41.5796971', N'2024-05-02 01:24:44.0142715', N'2024-05-02 01:24:44.0141001', N'2024-05-16 01:24:44.0143372', N'2024-05-02 01:24:46.8439879', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'5e35d397-b73f-4bc4-9430-6ff2145cf2f7', N'BR20240429155153', N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', NULL, N'5', N'2024-04-29 15:51:53.8093509', NULL, N'2024-04-29 15:52:00.7165028', N'2024-04-29 15:53:40.5644557', N'2024-04-29 15:53:40.5644531', N'2024-05-13 15:53:40.5644558', N'2024-05-06 00:29:43.5401037', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'62f1960c-b63a-4767-829f-018eaaa27901', N'BR20240506011710', N'F8FD3183-07E7-4E46-8C00-C36A1BA5F796', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'6', N'2024-05-04 01:17:10.7925266', N'2024-05-06 02:23:32.6868506', N'2024-05-04 01:17:54.7852183', NULL, NULL, N'2024-05-05 01:17:54.7855280', NULL, N'2024-05-06 01:57:42.9960232', N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'66293a91-cfd4-4af8-87de-125f3aa73be6', N'BR20240509213630', N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-09 21:36:30.1480239', NULL, N'2024-05-09 21:44:06.6877933', N'2024-05-09 21:44:57.6374737', N'2024-05-09 21:44:57.6367787', N'2024-07-04 21:44:57.6376078', N'2024-05-09 23:00:15.3943634', NULL, N'0', NULL, N'2024-05-09 22:58:27.7568240', N'1')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'67c7c4e0-e3d4-470c-9270-ae4fc7986d21', N'BR20240506000045', N'F8FD3183-07E7-4E46-8C00-C36A1BA5F796', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 00:00:45.4718279', NULL, N'2024-05-06 00:01:03.1430448', N'2024-05-06 00:04:34.2043447', N'2024-05-06 00:04:34.0168100', N'2024-05-20 00:04:34.4858006', N'2024-05-06 00:09:36.6732574', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'6c691b19-fda9-417c-8db5-4ad216b5333f', N'BR20240507231249', N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-07 23:12:49.5748632', NULL, N'2024-05-08 00:16:12.8212519', N'2024-05-08 00:16:22.3205398', N'2024-05-08 00:16:22.3205369', N'2024-05-22 00:16:22.3205400', N'2024-05-08 00:16:28.6615972', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'7656bef4-a324-4d8b-bdbf-a43d8413eea7', N'BR20240510083525', N'EBCC7BD4-C3E6-4569-AC51-5E7482F68938', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'4', N'2024-05-10 08:35:25.2315536', NULL, N'2024-05-10 08:36:13.1101201', N'2024-05-10 08:37:25.9712737', N'2024-05-10 08:37:25.9709850', N'2024-05-31 08:37:25.9714253', NULL, NULL, N'0', NULL, N'2024-05-10 08:38:13.6371245', N'1')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'79b83849-356c-43fd-914d-521b46857b8b', N'BR20240506004637', N'EBCC7BD4-C3E6-4569-AC51-5E7482F68938', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 00:46:37.6996241', NULL, N'2024-05-06 00:46:55.0681351', N'2024-05-06 00:50:01.0523876', N'2024-05-06 00:50:00.8901084', N'2024-05-20 00:50:01.3349087', N'2024-05-07 00:00:26.3668744', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'80c31eb2-ef19-4812-aab9-f2fde064426f', N'BR20240502015028', N'971C991C-CFAA-4830-8200-2E1F8EB3DB6F', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', NULL, N'5', N'2024-05-02 01:50:28.4151402', NULL, N'2024-05-06 00:53:47.3439394', N'2024-05-06 02:51:50.6137469', N'2024-05-06 02:51:50.6137443', N'2024-05-20 02:51:50.6137471', N'2024-05-07 00:00:46.5110629', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'8d9af0c5-0b66-4292-9f4c-a36e79b3c616', N'BR20240506001037', N'FFD578E9-C006-40B5-9F9B-8353EB512AE3', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 00:10:37.9292482', NULL, N'2024-05-06 00:10:53.1278116', N'2024-05-06 00:13:45.6671295', N'2024-05-06 00:13:45.5384379', N'2024-05-20 00:13:45.8380066', N'2024-05-06 00:19:36.8381203', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'93c0ec59-5ad5-498f-bcc9-f8eb11f13c36', N'BR20240506003102', N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 00:31:02.0932453', NULL, N'2024-05-06 00:31:16.9808384', N'2024-05-06 00:33:36.2811244', N'2024-05-06 00:33:35.9667854', N'2024-05-20 00:33:36.6353182', N'2024-05-07 00:00:32.6927735', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'94c20551-b6dc-4b28-a78d-f541279ed2d6', N'BR20240505235012', N'FFD578E9-C006-40B5-9F9B-8353EB512AE3', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-05 23:50:12.0374556', NULL, N'2024-05-05 23:53:35.4792889', N'2024-05-05 23:56:15.6377642', N'2024-05-05 23:56:15.3736995', N'2024-05-19 23:56:16.2616933', N'2024-05-06 00:09:44.7439102', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'9609ca7c-1df9-4a0f-b546-0c5ac6dd2c29', N'BR20240506001951', N'FFD578E9-C006-40B5-9F9B-8353EB512AE3', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 00:19:51.5500419', NULL, N'2024-05-06 00:20:17.5854549', N'2024-05-06 00:21:37.0949379', N'2024-05-06 00:21:36.9152866', N'2024-05-20 00:21:37.3428237', N'2024-05-07 00:01:06.3150525', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'96b26afa-c715-43f6-bc6c-0e1281632264', N'BR20240509231556', N'447BD9E3-D5D5-4BBB-9943-0E546567B702', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', NULL, N'2', N'2024-05-09 23:15:56.7351823', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'a3b89003-1c85-4c27-abed-873d0d2e696a', N'BR20240506021913', N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-06 02:19:13.6866659', NULL, N'2024-05-05 02:20:47.7700225', N'2024-05-06 02:51:22.7129608', N'2024-05-06 02:51:22.7129583', N'2024-05-20 02:51:22.7129611', N'2024-05-07 00:00:18.5054851', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'b0ce94ce-e176-478b-82d3-9fd7b44ba86b', N'BR20240509231650', N'537D2F89-9938-4AAE-854D-663663BFEA9E', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', NULL, N'3', N'2024-05-09 23:16:50.7022494', NULL, N'2024-05-09 23:17:11.4199629', NULL, NULL, N'2024-05-10 23:17:11.4199635', NULL, NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'b11f9dfe-c5f9-4104-a1a5-3f243c5c17ce', N'BR20240508001339', N'1575A9BA-3A5A-4CC9-9787-084DEFBA8B9F', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'4', NULL, NULL, NULL, N'2024-05-08 00:13:39.4788449', N'2024-05-08 00:13:39.4789325', N'2024-05-29 00:13:39.4789911', NULL, NULL, N'0', NULL, N'2024-05-09 23:00:56.2123082', N'1')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'b317d8da-a2f8-4428-814a-ba879ad2ffa7', N'BR20240426155628', N'033CE874-E040-4385-8B9A-140622DDD1A2', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-04-26 15:56:28.6999182', NULL, N'2024-04-26 16:04:17.0835555', N'2024-04-26 16:04:29.9250899', N'2024-04-26 16:04:29.9246438', N'2024-05-10 16:04:29.9252216', N'2024-04-26 16:05:55.0399185', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'b42059e5-9531-425b-b838-4a2ce570070c', N'BR20240507231255', N'da4b76e3-2d86-4f50-ab6e-c93a73d10e0e', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-05-07 23:12:55.0586715', NULL, N'2024-05-08 00:16:40.2796576', N'2024-05-08 00:16:47.2411616', N'2024-05-08 00:16:47.2411582', N'2024-05-22 00:16:47.2411618', N'2024-05-08 00:16:53.7665042', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'b4bffc51-70df-4b0c-93e0-39505a962291', N'BR20240508000031', N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', NULL, N'2', NULL, NULL, NULL, N'2024-05-08 00:00:31.1543029', NULL, NULL, NULL, NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'bce53f9b-7047-4f13-9da9-267e7f4cb0ce', N'BR20240430010447', N'537D2F89-9938-4AAE-854D-663663BFEA9E', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-04-30 01:04:47.3535418', NULL, N'2024-04-30 01:04:55.4297491', N'2024-04-30 01:11:10.2179043', N'2024-04-30 01:11:10.2177866', N'2024-05-21 01:11:10.2179422', N'2024-05-07 00:00:54.2131162', NULL, N'0', NULL, N'2024-05-03 15:32:58.0825157', N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'ca196804-c082-481a-93c7-470b293d2dba', N'BR20240429152037', N'4c0dc5ae-c609-4f5b-88eb-f8b81ab59439', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-04-29 15:20:37.0885897', NULL, N'2024-04-29 15:20:46.4438358', N'2024-04-29 15:20:48.8908327', N'2024-04-29 15:20:48.8907080', N'2024-05-13 15:20:48.8908731', N'2024-04-29 15:20:51.0783885', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'cea7ef28-16ce-4e7a-a6f1-8b9c641351ed', N'BR20240508001459', N'1575A9BA-3A5A-4CC9-9787-084DEFBA8B9F', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', NULL, N'5', NULL, NULL, NULL, N'2024-05-08 00:14:59.4111617', N'2024-05-08 00:14:59.4111623', N'2024-05-22 00:14:59.4111626', N'2024-05-08 13:53:22.0851781', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'e692ff3a-7741-40d3-ac3e-4e4a7cfe9fe6', N'BR20240430230024', N'EBCC7BD4-C3E6-4569-AC51-5E7482F68938', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-04-30 23:00:24.0089511', NULL, N'2024-05-06 00:27:12.3782225', N'2024-05-06 00:29:01.2583008', N'2024-05-06 00:29:01.1051466', N'2024-05-20 00:29:01.4695105', N'2024-05-06 00:29:32.7991070', NULL, N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'ea86fbcf-48f3-45ce-9520-d152e6c2084f', N'BR20240508000410', N'75211919-AABC-496A-9BEB-6CF63713E97B', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'7', NULL, NULL, NULL, N'2024-05-08 00:04:10.4239275', NULL, NULL, NULL, N'2024-05-08 12:45:48.4275340', N'0', NULL, NULL, N'0')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'fc43721b-5421-4a5f-838a-bdcfa072b299', N'BR20240508132448', N'75211919-AABC-496A-9BEB-6CF63713E97B', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'4', N'2024-05-08 13:24:48.2164236', NULL, N'2024-05-09 23:02:55.6911810', N'2024-05-09 23:03:14.5830279', N'2024-05-09 23:03:14.5830274', N'2024-05-30 23:03:14.5830280', NULL, NULL, N'0', NULL, N'2024-05-09 23:03:27.4437054', N'1')
GO

INSERT INTO [dbo].[BookRequests] ([Id], [Code], [BookDetailId], [UserAccountId], [BookCheckoutId], [Status], [CreatedTime], [RejectedTime], [ApprovedTime], [BorrowedTime], [ReceivedTime], [DueTime], [ReturnedTime], [CanceledTime], [IsDeleted], [Note], [ExtendedTime], [IsExtended]) VALUES (N'fc68160d-8c49-431e-b1a8-c2c401b0dc1a', N'BR20240416223850', N'eb7eae5e-c665-4635-aeb0-b05398f9ca87', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', NULL, N'5', N'2024-03-01 22:38:50.1998169', NULL, N'2024-02-02 00:00:53.9200544', N'2024-02-02 00:01:18.8478152', N'2024-03-02 00:01:18.8474646', N'2024-03-15 00:01:18.8479910', N'2024-03-15 00:04:10.8268005', NULL, N'0', NULL, NULL, N'0')
GO


-- ----------------------------
-- Table structure for Books
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type IN ('U'))
	DROP TABLE [dbo].[Books]
GO

CREATE TABLE [dbo].[Books] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CategoryId] int  NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL,
  [CreatedTime] datetime2(7) DEFAULT '2024-05-09T22:42:03.7205804+07:00' NULL,
  [UpdatedTime] datetime2(7) DEFAULT '2024-05-09T22:42:03.7206052+07:00' NULL
)
GO

ALTER TABLE [dbo].[Books] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Books
-- ----------------------------
INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'00000000-0000-0000-0000-000000000000', N'T-ara - day by day ~ lyrics on screen (KOR/ROM/ENG)', N'2', N'0', N'2024-05-04 02:12:52.1202416', N'2024-05-02 16:20:08.1198051')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'0220B35C-03FE-4507-8383-30BC8D905A28', N'ASP.NET Core Security', N'3', N'0', N'2024-04-09 23:13:37.0000000', N'2024-04-09 23:13:40.0000000')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'0E9B5F1B-0C7B-4093-9559-D3A7FE380832', N'Tìm mình trong thế giới hậu tuổi thơ', N'2', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'14FD5AC3-7C0D-4EFF-A840-E1589D1275EB', N'Systems Analysis and Design', N'7', N'0', N'2024-03-31 18:07:21.1576635', N'2024-03-31 18:07:21.1576886')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'1F50773D-4D51-4596-99B6-A624C2F61DDC', N'Building Web APIs with ASP.NET Core', N'7', N'0', N'2024-03-31 18:07:21.1576635', N'2024-03-31 18:07:21.1576886')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'3128D049-F7EC-4275-9BA8-9E10EE4F85EE', N'Nhập môn công nghệ phần mềm', N'6', N'0', N'2024-04-09 23:06:26.0000000', N'2024-03-31 18:07:21.1576886')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'34824C95-72D2-4861-A552-75BAC6F9508F  ', N'Rồi một ngày cuộc sống hóa hư vô', N'2', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'3ECC8999-CAEA-4C31-9A0E-37FF9158427E', N'Đảm bảo chất lượng phần mềm', N'6', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB', N'Từ điển tiếng Việt', N'4', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'507C99E1-1586-43C1-8831-E7B499C08EE0', N'Sapien lược sử loài người', N'3', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'8D573893-12ED-44E5-ABEF-8E0B17695223', N'Pro ASP.NET Core 7', N'7', N'0', N'2024-03-31 18:07:21.1576635', N'2024-03-31 18:07:21.1576886')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'90B5054A-9A37-4249-B1A1-209FFC7AE80D', N'Điều kỳ diệu của tiệm tạp hóa Namiya', N'1', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'A7A7CFF3-5B28-4921-9F06-599A3B14A776', N'Thần số học', N'3', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'ABF7E859-5FBA-4C19-B842-B442062C8909', N'Lược sử Trái Đất', N'3', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'ADC1F03D-BF8A-48B5-B9EA-4C9F63480566', N'API Design Patterns', N'3', N'0', N'2024-03-31 18:07:21.1576635', N'2024-03-31 18:07:21.1576886')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'AFE53773-D1B3-462D-B27E-8D37C1138639', N'Quán ăn nơi góc hẻm', N'1', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'B4A8198D-CE3E-49E4-A476-F7F2C4681B0D', N'Đất rừng phương nam', N'5', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'B575681C-AD00-49E9-B85E-82F738439CBF', N'Từ điển Hán Việt', N'4', N'0', N'2024-05-09 22:42:03.7205804', N'2024-05-09 22:42:03.7206052')
GO

INSERT INTO [dbo].[Books] ([Id], [Name], [CategoryId], [IsDeleted], [CreatedTime], [UpdatedTime]) VALUES (N'F62EE893-2588-4D12-A22E-E7855E2B9B51', N'The Design of Web APIs', N'7', N'0', N'2024-03-31 18:07:21.1576635', N'2024-03-31 18:07:21.1576886')
GO


-- ----------------------------
-- Table structure for BookShelfDetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BookShelfDetails]') AND type IN ('U'))
	DROP TABLE [dbo].[BookShelfDetails]
GO

CREATE TABLE [dbo].[BookShelfDetails] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [PublishedBookId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [BookShelfId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [IsDeleted] bit  NOT NULL
)
GO

ALTER TABLE [dbo].[BookShelfDetails] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BookShelfDetails
-- ----------------------------
INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'0186AA30-B0CF-4207-866C-5DDE289812D2', N'88863E59-F5F0-4052-8CE8-0081467F6F80', N'87310FFE-DEA0-4333-AD6D-9187009B3988', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'27184ECF-54F1-4500-AD2B-BBC1191FD588', N'FEC97CBC-599F-414E-B679-A1A86DC24E35', N'1CC716DF-B1E7-4693-9A7A-987457B9E362', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'2E1547FD-6293-4005-A48E-30033EEFE5D5', N'556DFDCF-5CCA-4434-B85A-18316C1B0B1E', N'8a509337-277f-4c0d-94d8-e693ccf58a96', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'4913DCF8-8F02-44EE-AE23-C2117FE219C1', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'9E7ADBED-1D3D-4263-AFEC-C11328A607A7', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'5C5274F2-D794-4C52-994F-B232DDA70B04', N'586FADA0-3F17-4C10-90E4-1354B8131753', N'aedab447-dd1f-4dad-becf-aa74ed03fe7b', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'6C8BD62F-D2AE-4128-B88B-161087966E01', N'7390FCA1-9278-4797-9778-8A082D0F2BDC', N'87310FFE-DEA0-4333-AD6D-9187009B3988', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'784AA988-7028-4EEF-88EF-FC8511A6AB40', N'B2B4A5F8-C2DB-4199-8C23-1F8C8150E662', N'8a509337-277f-4c0d-94d8-e693ccf58a96', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'8B146C4A-79AE-4762-99A6-3494B1CF30D7', N'9B15207E-FDDD-49EE-913B-851B05BD8F2D', N'8a509337-277f-4c0d-94d8-e693ccf58a96', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'8C182EE8-604B-4D03-8467-AAF9E0589AF7', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'B5C033B5-5AC2-47FA-9B0D-28C06FBFC89B', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'BB0C9190-AD59-4193-842C-9049EAF75F2C', N'460DCEB3-827D-4B83-8689-3F45F01C20A8', N'B5C033B5-5AC2-47FA-9B0D-28C06FBFC89B', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'c5103159-813c-48a5-b5b0-b3d12185fb10', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'aedab447-dd1f-4dad-becf-aa74ed03fe7b', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'D9A595E2-248F-4215-AF98-F77795D113D6', N'DD267F51-7A5B-41BC-A8BF-2988A333F527', N'1CC716DF-B1E7-4693-9A7A-987457B9E362', N'0')
GO

INSERT INTO [dbo].[BookShelfDetails] ([Id], [PublishedBookId], [BookShelfId], [IsDeleted]) VALUES (N'e6ef33c8-e912-43ef-af95-03b07bc4f2e9', N'FB51AB25-2788-4B0E-996E-2A68282B2C88', N'8a509337-277f-4c0d-94d8-e693ccf58a96', N'0')
GO


-- ----------------------------
-- Table structure for BookShelves
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BookShelves]') AND type IN ('U'))
	DROP TABLE [dbo].[BookShelves]
GO

CREATE TABLE [dbo].[BookShelves] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsDeleted] bit  NOT NULL
)
GO

ALTER TABLE [dbo].[BookShelves] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BookShelves
-- ----------------------------
INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'1CC716DF-B1E7-4693-9A7A-987457B9E362', N'SH-003-C', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'2B7C5E34-79E3-473C-ACD8-7C6277A6FA78', N'SH-002-B', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'4AE0DCBE-8F56-448B-91AD-3AAF4A4CA7E0', N'SH-002-C', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'87310FFE-DEA0-4333-AD6D-9187009B3988', N'SH-003-B', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'8a509337-277f-4c0d-94d8-e693ccf58a96', N'SH-001-B', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'9E7ADBED-1D3D-4263-AFEC-C11328A607A7', N'SH-001-D', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'9EB0C288-7529-43E2-A688-609A05D3EC6E', N'SH-002-D', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'aedab447-dd1f-4dad-becf-aa74ed03fe7b', N'SH-001-A', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'B5C033B5-5AC2-47FA-9B0D-28C06FBFC89B', N'SH-003-A', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'da29aa39-bfca-4405-b8fe-b21ee816f404', N'SH-002-A', N'0')
GO

INSERT INTO [dbo].[BookShelves] ([Id], [Name], [IsDeleted]) VALUES (N'F389B567-8CF0-4B37-9F3F-C5ECB98CDB4D', N'SH-001-C', N'0')
GO


-- ----------------------------
-- Table structure for Categories
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type IN ('U'))
	DROP TABLE [dbo].[Categories]
GO

CREATE TABLE [dbo].[Categories] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedDate] datetime2(7) DEFAULT '2024-05-09T22:42:03.7207303+07:00' NULL,
  [UpdatedDate] datetime2(7) DEFAULT '2024-05-09T22:42:03.7207525+07:00' NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NOT NULL
)
GO

ALTER TABLE [dbo].[Categories] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Categories
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Categories] ON
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'1', N'Tiểu thuyết', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'2', N'Sách tâm lý', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'3', N'Sách khoa học', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'4', N'Từ điển', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'5', N'Sách văn học', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'6', N'Giáo trình', N'2024-05-09 22:42:03.7207303', N'2024-05-09 22:42:03.7207525', N'0')
GO

INSERT INTO [dbo].[Categories] ([Id], [Name], [CreatedDate], [UpdatedDate], [IsDeleted]) VALUES (N'7', N'Sách học thuật', N'2024-03-31 18:07:21.1577695', N'2024-03-31 18:07:21.1577905', N'0')
GO

SET IDENTITY_INSERT [dbo].[Categories] OFF
GO


-- ----------------------------
-- Table structure for Comments
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Comments]') AND type IN ('U'))
	DROP TABLE [dbo].[Comments]
GO

CREATE TABLE [dbo].[Comments] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [BlogId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [UserAccountId] uniqueidentifier  NOT NULL,
  [Content] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedDate] datetime2(7) DEFAULT '2024-05-09T22:42:03.7209235+07:00' NULL,
  [ReplyCommentId] int  NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NULL
)
GO

ALTER TABLE [dbo].[Comments] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Comments
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Comments] ON
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'200', N'BL20240430230453', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Trước tiên chúng ta cần hiểu Front-end và Back-end là gì? Back-end cũng là phần mà người dùng không nhìn thấy được như Front-end, hay như chúng ta vẫn hay ví von đấy là phần chìm của tảng băng trôi. Có sự khác biệt rõ ràng giữa ứng dụng tạo ra ở 2 phía', N'2024-04-30 23:07:03.0097192', NULL, N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'201', N'BL20240502014239', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'Hay lắm bạn! Chia sẻ thêm nhé!', N'2024-05-02 01:43:54.4830439', NULL, N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'202', N'BL20240502014239', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Dữ vậy sao!', N'2024-05-02 01:44:21.9067259', N'201', N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'203', N'BL20240501223554', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Hay lắm bạn! Chia sẻ thêm nhé!', N'2024-05-07 00:21:27.1266049', NULL, N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'204', N'BL20240501223554', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'test reply', N'2024-05-07 00:21:36.6422582', N'203', N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'205', N'BL20240502014239', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'Cảm ơn bạn nhiều nhé', N'2024-05-09 23:18:39.2933530', N'201', N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'206', N'BL20240510084029', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'Bạn này chia sẻ hay quá!', N'2024-05-10 08:42:40.3633502', NULL, N'0')
GO

INSERT INTO [dbo].[Comments] ([Id], [BlogId], [UserAccountId], [Content], [CreatedDate], [ReplyCommentId], [IsDeleted]) VALUES (N'207', N'BL20240510084029', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'hihi', N'2024-05-10 08:42:51.1866606', N'206', N'0')
GO

SET IDENTITY_INSERT [dbo].[Comments] OFF
GO


-- ----------------------------
-- Table structure for FeedBacks
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[FeedBacks]') AND type IN ('U'))
	DROP TABLE [dbo].[FeedBacks]
GO

CREATE TABLE [dbo].[FeedBacks] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [UserAccountId] uniqueidentifier  NOT NULL,
  [PublishedBookId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Content] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Rate] float(53) DEFAULT 0.0000000000000000e+000 NOT NULL,
  [IsDeleted] bit DEFAULT CONVERT([bit],(0)) NULL,
  [CreatedDate] datetime2(7) DEFAULT '2024-05-09T22:42:03.7210481+07:00' NULL
)
GO

ALTER TABLE [dbo].[FeedBacks] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of FeedBacks
-- ----------------------------
SET IDENTITY_INSERT [dbo].[FeedBacks] ON
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'5', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'Tìm mình trong thế giới hậu tuổi thơ kể về những câu chuyện của người trẻ trên dưới hai mươi, cái độ tuổi chưa hẳn là người lớn nhưng đã qua cái thời ngây thơ của một đứa trẻ. Mỗi người có một câu chuyện, hoàn cảnh khác nhau, nhưng họ đều có một điểm chung là cảm thấy ngột ngạt, bức bách, mơ hồ với cuộc sống, với gia đình. Tất cả các câu chuyện đều được kể lại theo một cách tự nhiên nhất, không phân tích, không phán xét, một cuốn sách tâm lý không giáo điều. Cuốn sách sẽ khiến những người trẻ hiểu hơn về những tâm lý, suy nghĩ của chính mình và làm các bậc cha mẹ phải suy xét lại những hành động, tư tưởng dành cho con cái mình từ trước cho đến giờ.', N'4', N'0', N'2024-04-15 09:16:11.6360085')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'8', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'Chưa hay lắm', N'1', N'0', N'2024-04-15 15:08:20.8282966')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'11', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'Sách hay lắm, mình đọc lại lần 2 rồi!', N'5', N'0', N'2024-04-15 15:47:00.4663818')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'12', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'Sách hay lắm', N'4.5', N'0', N'2024-05-02 01:25:20.6949090')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'13', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'', N'4', N'0', N'2024-05-06 14:15:19.7481456')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'14', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'Sách hay!', N'3.5', N'0', N'2024-05-07 00:20:55.6831212')
GO

INSERT INTO [dbo].[FeedBacks] ([Id], [UserAccountId], [PublishedBookId], [Content], [Rate], [IsDeleted], [CreatedDate]) VALUES (N'15', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'Bổ ích lắm, các bạn nên tìm hiểu về quyển sách này nha', N'4.5', N'0', N'2024-05-09 21:35:24.4886137')
GO

SET IDENTITY_INSERT [dbo].[FeedBacks] OFF
GO


-- ----------------------------
-- Table structure for PublishedBooks
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PublishedBooks]') AND type IN ('U'))
	DROP TABLE [dbo].[PublishedBooks]
GO

CREATE TABLE [dbo].[PublishedBooks] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [BookId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Code] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Image] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'default.png' NULL,
  [PublisherId] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Pages] int  NOT NULL,
  [PublishedYear] int  NOT NULL,
  [Rating] float(53)  NOT NULL,
  [Checkout_visit] int  NOT NULL
)
GO

ALTER TABLE [dbo].[PublishedBooks] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PublishedBooks
-- ----------------------------
INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'0BDD9ABE-CBD6-4AF5-A33E-04728E00BA73', N'90B5054A-9A37-4249-B1A1-209FFC7AE80D', N'PB20241604205832', N'2.png', N'A1D207B4-F571-4447-8FE0-E00B2F2D2724', N'358', N'2016', N'0', N'9')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'4065BD3C-6BCB-4CE9-AB22-5650A4C872F8', N'14FD5AC3-7C0D-4EFF-A840-E1589D1275EB', N'PB20240409115143', N'81AfTuXCNjL._SY466_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'464', N'2021', N'0', N'4')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'460DCEB3-827D-4B83-8689-3F45F01C20A8', N'8D573893-12ED-44E5-ABEF-8E0B17695223', N'PB20240904112182', N'61xVBSxJ3CL._SY466_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'1256', N'2023', N'0', N'2')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'556DFDCF-5CCA-4434-B85A-18316C1B0B1E', N'B575681C-AD00-49E9-B85E-82F738439CBF', N'PB20240116211265', N'7.png', N'8ACAC782-F299-4F02-ACF6-D75B30612A42', N'465', N'2020', N'0', N'0')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'586FADA0-3F17-4C10-90E4-1354B8131753', N'507C99E1-1586-43C1-8831-E7B499C08EE0', N'PB20240416211043', N'10.png', N'95A62DE9-2EF5-4B15-9727-1F54C75790AB', N'600', N'2022', N'0', N'0')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'7390FCA1-9278-4797-9778-8A082D0F2BDC', N'0220B35C-03FE-4507-8383-30BC8D905A28', N'PB20240904111589', N'61QZZ1eYX0L._SL1500_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'368', N'2011', N'0', N'6')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'7F33BDA5-7C2B-447A-89E3-DC670ACC3646', N'0E9B5F1B-0C7B-4093-9559-D3A7FE380832', N'PB20240509224203', N'1.png', N'A1D207B4-F571-4447-8FE0-E00B2F2D2724', N'404', N'2020', N'4.3', N'17')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'88863E59-F5F0-4052-8CE8-0081467F6F80', N'ADC1F03D-BF8A-48B5-B9EA-4C9F63480566', N'PB20240904114366', N'71-Q7YOvWkL._SY466_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'480', N'2021', N'0', N'0')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'9B15207E-FDDD-49EE-913B-851B05BD8F2D', N'4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB', N'PB20240416211445', N'6.png', N'8ACAC782-F299-4F02-ACF6-D75B30612A42', N'1491', N'2019', N'0', N'0')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'B2B4A5F8-C2DB-4199-8C23-1F8C8150E662', N'3128D049-F7EC-4275-9BA8-9E10EE4F85EE', N'PB20240904110867', N'nhapmoncnpm.jpg', N'E1B5B1AB-69C9-4D5A-8148-3823605D855A', N'114', N'2011', N'3', N'11')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'DD267F51-7A5B-41BC-A8BF-2988A333F527', N'1F50773D-4D51-4596-99B6-A624C2F61DDC', N'PB20240904111854', N'61+2ffMllqL._SL1500_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'472', N'2023', N'0', N'0')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'FB51AB25-2788-4B0E-996E-2A68282B2C88', N'3ECC8999-CAEA-4C31-9A0E-37FF9158427E', N'PB20240509224203', N'giaotrinhdbclpm.png', N'E1B5B1AB-69C9-4D5A-8148-3823605D855A', N'312', N'2012', N'2.3', N'9')
GO

INSERT INTO [dbo].[PublishedBooks] ([Id], [BookId], [Code], [Image], [PublisherId], [Pages], [PublishedYear], [Rating], [Checkout_visit]) VALUES (N'FEC97CBC-599F-414E-B679-A1A86DC24E35', N'F62EE893-2588-4D12-A22E-E7855E2B9B51', N'PB20240904114035', N'61ZND26BDZL._SY466_.jpg', N'3AD141CE-724C-4053-85C2-9A09312C4150', N'400', N'2019', N'0', N'5')
GO


-- ----------------------------
-- Table structure for Publisher
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Publisher]') AND type IN ('U'))
	DROP TABLE [dbo].[Publisher]
GO

CREATE TABLE [dbo].[Publisher] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Publisher] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Publisher
-- ----------------------------
INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'1712E51B-0E16-41AC-8CC4-28BCDFCA9A98', N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'1E81F92D-2DB9-44CA-99B4-980B51D1E0C7', N'Nhà xuất bản Trường Đại học Cần Thơ')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'3AD141CE-724C-4053-85C2-9A09312C4150', N'Manning')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'4D9FF82E-2B49-47D8-B5ED-43FEE479883D', N'Nhà xuất bản Kim Đồng')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'8ACAC782-F299-4F02-ACF6-D75B30612A42', N'Nhà xuất bản Hồng Đức')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'95A62DE9-2EF5-4B15-9727-1F54C75790AB', N'Nhà xuất bản Tri thức')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'A1D207B4-F571-4447-8FE0-E00B2F2D2724', N'Nhà xuất bản Hội Nhà Văn')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'B1049AEC-30EA-4C8C-8DCC-D35F3AC17C90', N'Nhà xuất bản Trẻ')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'E1B5B1AB-69C9-4D5A-8148-3823605D855A', N'Nhà xuất bản Đại học Cần Thơ')
GO

INSERT INTO [dbo].[Publisher] ([Id], [Name]) VALUES (N'F28F2290-EE06-4831-9091-8124FE61DFB9', N'Nhà xuất bản Lao động')
GO


-- ----------------------------
-- Table structure for RoleClaims
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleClaims]') AND type IN ('U'))
	DROP TABLE [dbo].[RoleClaims]
GO

CREATE TABLE [dbo].[RoleClaims] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [RoleId] uniqueidentifier  NOT NULL,
  [ClaimType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ClaimValue] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[RoleClaims] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoleClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RoleClaims] ON
GO

SET IDENTITY_INSERT [dbo].[RoleClaims] OFF
GO


-- ----------------------------
-- Table structure for Roles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type IN ('U'))
	DROP TABLE [dbo].[Roles]
GO

CREATE TABLE [dbo].[Roles] (
  [Id] uniqueidentifier  NOT NULL,
  [Name] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NormalizedName] nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ConcurrencyStamp] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Roles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Roles
-- ----------------------------
INSERT INTO [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31', N'User', N'USER', N'fc732407-4445-4ae5-9411-c696d6c6f44a')
GO

INSERT INTO [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9E87B492-5343-4272-9A34-FA5DE7CFFB22', N'Admin', N'ADMIN', N'1c353de0-babd-40bb-a825-59faa88dd280')
GO


-- ----------------------------
-- Table structure for Topics
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Topics]') AND type IN ('U'))
	DROP TABLE [dbo].[Topics]
GO

CREATE TABLE [dbo].[Topics] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CreatedTime] datetime2(7)  NOT NULL,
  [UpdatedTime] datetime2(7)  NOT NULL,
  [IsDeleted] bit  NOT NULL
)
GO

ALTER TABLE [dbo].[Topics] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Topics
-- ----------------------------
INSERT INTO [dbo].[Topics] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'11DA51DA-74C5-4600-AAD0-65E1E32B11D2', N'Hỏi đáp', N'2024-04-30 23:06:00.0000000', N'2024-04-30 23:06:03.0000000', N'0')
GO

INSERT INTO [dbo].[Topics] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88', N'Lập trình', N'0001-01-01 00:00:00.0000000', N'0001-01-01 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[Topics] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'5F8E994D-85E4-441D-9197-988250165E28', N'Tin tuyển dụng', N'2024-05-01 22:37:18.0000000', N'2024-05-01 22:37:21.0000000', N'0')
GO

INSERT INTO [dbo].[Topics] ([Id], [Name], [CreatedTime], [UpdatedTime], [IsDeleted]) VALUES (N'D2AB6BB4-0A82-4D2C-B70E-03DD1C3BE23D', N'Phỏng vấn', N'0001-01-01 00:00:00.0000000', N'0001-01-01 00:00:00.0000000', N'0')
GO


-- ----------------------------
-- Table structure for UserClaims
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UserClaims]') AND type IN ('U'))
	DROP TABLE [dbo].[UserClaims]
GO

CREATE TABLE [dbo].[UserClaims] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [UserId] uniqueidentifier  NOT NULL,
  [ClaimType] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ClaimValue] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[UserClaims] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UserClaims
-- ----------------------------
SET IDENTITY_INSERT [dbo].[UserClaims] ON
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'1', N'372EA575-2536-4076-9BAB-3E3138DE495F', N'id', N'372ea575-2536-4076-9bab-3e3138de495f')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'2', N'372EA575-2536-4076-9BAB-3E3138DE495F', N'email', N'johnminscarslbm@gmail.com')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'3', N'372EA575-2536-4076-9BAB-3E3138DE495F', N'roles', N'Admin')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'4', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'id', N'2a738bf3-a14b-488e-b04e-17f918e8d6a4')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'5', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'email', N'khab2012213@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'6', N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'roles', N'User')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'7', N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'id', N'f5aa72ea-a563-4e89-a289-e290814f3c17')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'8', N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'email', N'lamb1809363@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'9', N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'roles', N'User')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'10', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'id', N'f4e9077d-d904-4c9e-860e-7c0373cfddff')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'11', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'email', N'theb2003923@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'12', N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'roles', N'User')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'13', N'5BB18865-B42E-4EF0-844F-9AC649AB1732', N'id', N'5bb18865-b42e-4ef0-844f-9ac649ab1732')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'14', N'5BB18865-B42E-4EF0-844F-9AC649AB1732', N'email', N'linhb2012223@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'15', N'5BB18865-B42E-4EF0-844F-9AC649AB1732', N'roles', N'User')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'16', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'id', N'd1f58d0a-78fc-4564-8642-3b63d71763ac')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'17', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'email', N'nhanb2012237@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'18', N'D1F58D0A-78FC-4564-8642-3B63D71763AC', N'roles', N'User')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'19', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'id', N'5b01ec43-afdc-4117-8212-fe47feb3a5f4')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'20', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'email', N'nhungb1914237@student.ctu.edu.vn')
GO

INSERT INTO [dbo].[UserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (N'21', N'5B01EC43-AFDC-4117-8212-FE47FEB3A5F4', N'roles', N'User')
GO

SET IDENTITY_INSERT [dbo].[UserClaims] OFF
GO


-- ----------------------------
-- Table structure for UserLogins
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogins]') AND type IN ('U'))
	DROP TABLE [dbo].[UserLogins]
GO

CREATE TABLE [dbo].[UserLogins] (
  [LoginProvider] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProviderKey] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProviderDisplayName] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [UserId] uniqueidentifier  NOT NULL
)
GO

ALTER TABLE [dbo].[UserLogins] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UserLogins
-- ----------------------------

-- ----------------------------
-- Table structure for UserRoles
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRoles]') AND type IN ('U'))
	DROP TABLE [dbo].[UserRoles]
GO

CREATE TABLE [dbo].[UserRoles] (
  [UserId] uniqueidentifier  NOT NULL,
  [RoleId] uniqueidentifier  NOT NULL
)
GO

ALTER TABLE [dbo].[UserRoles] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UserRoles
-- ----------------------------
INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'2A738BF3-A14B-488E-B04E-17F918E8D6A4', N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31')
GO

INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'F4E9077D-D904-4C9E-860E-7C0373CFDDFF', N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31')
GO

INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'F5AA72EA-A563-4E89-A289-E290814F3C17', N'8F7579EE-4AF9-4B71-9ADA-7F792F76DC31')
GO

INSERT INTO [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'372EA575-2536-4076-9BAB-3E3138DE495F', N'9E87B492-5343-4272-9A34-FA5DE7CFFB22')
GO


-- ----------------------------
-- Table structure for Users
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type IN ('U'))
	DROP TABLE [dbo].[Users]
GO

CREATE TABLE [dbo].[Users] (
  [Id] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [UserCode] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Email] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PhoneNumber] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Address] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Users
-- ----------------------------
INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'1B1BC693-F841-4B2D-9567-63710DA34F1D', N'B2012223', N'Lưu Hoàng Lỉnh', NULL, N'0123456789', N'Cái Răng, TP. Cần Thơ')
GO

INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'8A820ADB-93D7-4C6F-9404-BDBFC14419F4', N'B2012213', N'Lê Minh Kha', NULL, N'0398897634', N'Đường 3/2, phường Xuân Khánh, quận Ninh Kiều, TP. Cần Thơ')
GO

INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'B03DE8D3-DFD7-4A25-B081-20FB1696DB22', N'B1914237', N'Huỳnh Yến Nhung', NULL, N'098769876', N'Ký túc xá A, Trường Đại học Cần Thơ')
GO

INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C', N'B1809363', N'Nguyễn Tùng Lâm', NULL, N'0338307449', N'87 Lê Văn Huân, Phường 13, Quận Tân Bình, TP. Hồ Chí Minh')
GO

INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B', N'B2012237', N'Nguyễn Trung Nhẩn', NULL, N'0122334455', N'Hẻm 51, TP. Cần Thơ')
GO

INSERT INTO [dbo].[Users] ([Id], [UserCode], [Name], [Email], [PhoneNumber], [Address]) VALUES (N'F7AA67C1-B3CB-4CCE-9394-1630407343BF', N'B2003923', N'Trần Chí Thể', NULL, N'1234567890', N'Ninh Kiều, TP. Cần Thơ')
GO


-- ----------------------------
-- Table structure for UserTokens
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UserTokens]') AND type IN ('U'))
	DROP TABLE [dbo].[UserTokens]
GO

CREATE TABLE [dbo].[UserTokens] (
  [UserId] uniqueidentifier  NOT NULL,
  [LoginProvider] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Name] nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Value] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[UserTokens] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UserTokens
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Accounts
-- ----------------------------
CREATE NONCLUSTERED INDEX [EmailIndex]
ON [dbo].[Accounts] (
  [NormalizedEmail] ASC
)
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Accounts_UserId]
ON [dbo].[Accounts] (
  [UserId] ASC
)
WHERE ([UserId] IS NOT NULL)
GO

CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
ON [dbo].[Accounts] (
  [NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
GO


-- ----------------------------
-- Primary Key structure for table Accounts
-- ----------------------------
ALTER TABLE [dbo].[Accounts] ADD CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Authors
-- ----------------------------
ALTER TABLE [dbo].[Authors] ADD CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Blogs
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Blogs_UserAccountId]
ON [dbo].[Blogs] (
  [UserAccountId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_Blogs_TopicId]
ON [dbo].[Blogs] (
  [TopicId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Blogs
-- ----------------------------
ALTER TABLE [dbo].[Blogs] ADD CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table BookAuthors
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_BookAuthors_BookId]
ON [dbo].[BookAuthors] (
  [BookId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table BookAuthors
-- ----------------------------
ALTER TABLE [dbo].[BookAuthors] ADD CONSTRAINT [PK_BookAuthors] PRIMARY KEY CLUSTERED ([AuthorId], [BookId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table BookDetails
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_BookDetails_PublishedBookId]
ON [dbo].[BookDetails] (
  [PublishedBookId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table BookDetails
-- ----------------------------
ALTER TABLE [dbo].[BookDetails] ADD CONSTRAINT [PK_BookDetails] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table BookRequests
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_BookRequests_BookDetailId]
ON [dbo].[BookRequests] (
  [BookDetailId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_BookRequests_UserAccountId]
ON [dbo].[BookRequests] (
  [UserAccountId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table BookRequests
-- ----------------------------
ALTER TABLE [dbo].[BookRequests] ADD CONSTRAINT [PK_BookRequests] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Books
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Books_CategoryId]
ON [dbo].[Books] (
  [CategoryId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Books
-- ----------------------------
ALTER TABLE [dbo].[Books] ADD CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table BookShelfDetails
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_BookShelfDetails_BookShelfId]
ON [dbo].[BookShelfDetails] (
  [BookShelfId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_BookShelfDetails_PublishedBookId]
ON [dbo].[BookShelfDetails] (
  [PublishedBookId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table BookShelfDetails
-- ----------------------------
ALTER TABLE [dbo].[BookShelfDetails] ADD CONSTRAINT [PK_BookShelfDetails] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table BookShelves
-- ----------------------------
ALTER TABLE [dbo].[BookShelves] ADD CONSTRAINT [PK_BookShelves] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Categories
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Categories]', RESEED, 7)
GO


-- ----------------------------
-- Primary Key structure for table Categories
-- ----------------------------
ALTER TABLE [dbo].[Categories] ADD CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Comments
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Comments]', RESEED, 207)
GO


-- ----------------------------
-- Indexes structure for table Comments
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_Comments_BlogId]
ON [dbo].[Comments] (
  [BlogId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_Comments_UserAccountId]
ON [dbo].[Comments] (
  [UserAccountId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Comments
-- ----------------------------
ALTER TABLE [dbo].[Comments] ADD CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for FeedBacks
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[FeedBacks]', RESEED, 15)
GO


-- ----------------------------
-- Indexes structure for table FeedBacks
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_FeedBacks_PublishedBookId]
ON [dbo].[FeedBacks] (
  [PublishedBookId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_FeedBacks_UserAccountId]
ON [dbo].[FeedBacks] (
  [UserAccountId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table FeedBacks
-- ----------------------------
ALTER TABLE [dbo].[FeedBacks] ADD CONSTRAINT [PK_FeedBacks] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table PublishedBooks
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_PublishedBooks_BookId]
ON [dbo].[PublishedBooks] (
  [BookId] ASC
)
GO

CREATE NONCLUSTERED INDEX [IX_PublishedBooks_PublisherId]
ON [dbo].[PublishedBooks] (
  [PublisherId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table PublishedBooks
-- ----------------------------
ALTER TABLE [dbo].[PublishedBooks] ADD CONSTRAINT [PK_PublishedBooks] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Publisher
-- ----------------------------
ALTER TABLE [dbo].[Publisher] ADD CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for RoleClaims
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[RoleClaims]', RESEED, 1)
GO


-- ----------------------------
-- Indexes structure for table RoleClaims
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId]
ON [dbo].[RoleClaims] (
  [RoleId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table RoleClaims
-- ----------------------------
ALTER TABLE [dbo].[RoleClaims] ADD CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table Roles
-- ----------------------------
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
ON [dbo].[Roles] (
  [NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
GO


-- ----------------------------
-- Primary Key structure for table Roles
-- ----------------------------
ALTER TABLE [dbo].[Roles] ADD CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Topics
-- ----------------------------
ALTER TABLE [dbo].[Topics] ADD CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for UserClaims
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[UserClaims]', RESEED, 21)
GO


-- ----------------------------
-- Indexes structure for table UserClaims
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId]
ON [dbo].[UserClaims] (
  [UserId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table UserClaims
-- ----------------------------
ALTER TABLE [dbo].[UserClaims] ADD CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table UserLogins
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_UserLogins_UserId]
ON [dbo].[UserLogins] (
  [UserId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table UserLogins
-- ----------------------------
ALTER TABLE [dbo].[UserLogins] ADD CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Indexes structure for table UserRoles
-- ----------------------------
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId]
ON [dbo].[UserRoles] (
  [RoleId] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table UserRoles
-- ----------------------------
ALTER TABLE [dbo].[UserRoles] ADD CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED ([UserId], [RoleId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Users
-- ----------------------------
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table UserTokens
-- ----------------------------
ALTER TABLE [dbo].[UserTokens] ADD CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED ([UserId], [LoginProvider], [Name])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Accounts
-- ----------------------------
ALTER TABLE [dbo].[Accounts] ADD CONSTRAINT [FK_Accounts_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Blogs
-- ----------------------------
ALTER TABLE [dbo].[Blogs] ADD CONSTRAINT [FK_Blogs_Accounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Blogs] ADD CONSTRAINT [FK_Blogs_Topics_TopicId] FOREIGN KEY ([TopicId]) REFERENCES [dbo].[Topics] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table BookAuthors
-- ----------------------------
ALTER TABLE [dbo].[BookAuthors] ADD CONSTRAINT [FK_BookAuthors_Authors_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Authors] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[BookAuthors] ADD CONSTRAINT [FK_BookAuthors_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table BookDetails
-- ----------------------------
ALTER TABLE [dbo].[BookDetails] ADD CONSTRAINT [FK_BookDetails_PublishedBooks_PublishedBookId] FOREIGN KEY ([PublishedBookId]) REFERENCES [dbo].[PublishedBooks] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table BookRequests
-- ----------------------------
ALTER TABLE [dbo].[BookRequests] ADD CONSTRAINT [FK_BookRequests_Accounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[BookRequests] ADD CONSTRAINT [FK_BookRequests_BookDetails_BookDetailId] FOREIGN KEY ([BookDetailId]) REFERENCES [dbo].[BookDetails] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Books
-- ----------------------------
ALTER TABLE [dbo].[Books] ADD CONSTRAINT [FK_Books_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table BookShelfDetails
-- ----------------------------
ALTER TABLE [dbo].[BookShelfDetails] ADD CONSTRAINT [FK_BookShelfDetails_BookShelves_BookShelfId] FOREIGN KEY ([BookShelfId]) REFERENCES [dbo].[BookShelves] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[BookShelfDetails] ADD CONSTRAINT [FK_BookShelfDetails_PublishedBooks_PublishedBookId] FOREIGN KEY ([PublishedBookId]) REFERENCES [dbo].[PublishedBooks] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Comments
-- ----------------------------
ALTER TABLE [dbo].[Comments] ADD CONSTRAINT [FK_Comments_Accounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Comments] ADD CONSTRAINT [FK_Comments_Blogs_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [dbo].[Blogs] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table FeedBacks
-- ----------------------------
ALTER TABLE [dbo].[FeedBacks] ADD CONSTRAINT [FK_FeedBacks_Accounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[FeedBacks] ADD CONSTRAINT [FK_FeedBacks_PublishedBooks_PublishedBookId] FOREIGN KEY ([PublishedBookId]) REFERENCES [dbo].[PublishedBooks] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PublishedBooks
-- ----------------------------
ALTER TABLE [dbo].[PublishedBooks] ADD CONSTRAINT [FK_PublishedBooks_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PublishedBooks] ADD CONSTRAINT [FK_PublishedBooks_Publisher_PublisherId] FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publisher] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table RoleClaims
-- ----------------------------
ALTER TABLE [dbo].[RoleClaims] ADD CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table UserClaims
-- ----------------------------
ALTER TABLE [dbo].[UserClaims] ADD CONSTRAINT [FK_UserClaims_Accounts_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table UserLogins
-- ----------------------------
ALTER TABLE [dbo].[UserLogins] ADD CONSTRAINT [FK_UserLogins_Accounts_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table UserRoles
-- ----------------------------
ALTER TABLE [dbo].[UserRoles] ADD CONSTRAINT [FK_UserRoles_Accounts_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[UserRoles] ADD CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table UserTokens
-- ----------------------------
ALTER TABLE [dbo].[UserTokens] ADD CONSTRAINT [FK_UserTokens_Accounts_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


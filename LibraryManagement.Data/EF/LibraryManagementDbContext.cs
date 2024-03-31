using LibraryManagement.Data.Configurations;
using LibraryManagement.Data.Extentions;
using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.EF
{
    public class LibraryManagementDbContext : IdentityDbContext<UserAccount, UserRole, Guid>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { set; get; }
        public DbSet<UserAccount> AppUserAccounts { set; get; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Request> Requests { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }
        public DbSet<Blog> Blogs {  set; get; }
        public DbSet<Comment> Comments { set; get; }
        public DbSet<FeedBack> FeedBacks { set; get; }
        public DbSet<Publisher> Publisher { set; get; }
        public DbSet<BookCheckout> BookCheckouts { set; get; }
        public DbSet<PublishedBook> PublishedBooks { set; get; }    
        public DbSet<BookDetail> BookDetails { set; get; }
        public DbSet<BookRequest> BookRequests { set; get; }
        public DbSet<BookAuthor> BookAuthors { set; get; }
        public DbSet<Author> Authors { set; get; }
        public DbSet<BookShelf> BookShelves { set; get; }
        public DbSet<BookShelfDetail> BookShelfDetails { set; get; }

        public LibraryManagementDbContext(DbContextOptions<LibraryManagementDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfig())
                        .ApplyConfiguration(new UserAccountConfig())
                        .ApplyConfiguration(new CategoryConfig())
                        .ApplyConfiguration(new BlogConfig())
                        .ApplyConfiguration(new CommentConfig())
                        .ApplyConfiguration(new FeedBackConfig())
                        .ApplyConfiguration(new PublisherConfig())
                        .ApplyConfiguration(new BookCheckoutConfig())
                        .ApplyConfiguration(new BookDetailConfig())
                        .ApplyConfiguration(new PublisherConfig())
                        .ApplyConfiguration(new PublishedBookConfig())
                        .ApplyConfiguration(new UserConfig())
                        .ApplyConfiguration(new BookAuthorConfig())
                        .ApplyConfiguration(new BookShelfConfig())
                        .ApplyConfiguration(new BookShelfDetailConfig());

            modelBuilder.FillDataCategory();
            modelBuilder.FillDataBook();
            modelBuilder.FillDataUser();
            modelBuilder.FillDataUserAccount();
            modelBuilder.FillDataAuthor();
            modelBuilder.FillDataBookAuthor();
            modelBuilder.FillDataPublisher();
            modelBuilder.FillDataPublishedBook();
            modelBuilder.FillDataBookRequest();
            modelBuilder.FillDataBookDetail();
            modelBuilder.FillDataBlog();
            modelBuilder.FillDataComment();
            modelBuilder.FillDataFeedBack();
            modelBuilder.FillDataBookShelf();
            modelBuilder.FillDataBookShelfDetail();

            //modelBuilder.FillDataBookCheckout();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.ToTable(name: "Accounts");
            });
            

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName!.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}

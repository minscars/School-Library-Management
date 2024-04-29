using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Data.EF;
using System.Text.Json.Serialization;
using LibraryManagement.Application.Mapping;
using Microsoft.AspNetCore.Identity;
using LibraryManagement.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
                      policy =>
                      {
                          policy.SetIsOriginAllowed(a => true)
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

builder.Services.AddDbContext<LibraryManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")),
    ServiceLifetime.Transient);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryManagement.Api", Version = "v1" });
});

//Add Identity
builder.Services.AddIdentity<UserAccount, UserRole>()
        .AddEntityFrameworkStores<LibraryManagementDbContext>()
        .AddDefaultTokenProviders();

//Setting password
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
options.Password.RequireLowercase = false;
options.Password.RequireNonAlphanumeric = false;
options.Password.RequireUppercase = false;
options.Password.RequiredLength = 0;
options.Password.RequiredUniqueChars = 0;
});


//Add automapper
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

//DI

//builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserAccountService, UserAccountService>();
builder.Services.AddTransient<IUserRoleService, UserRoleService>();
builder.Services.AddTransient<UserManager<UserAccount>, UserManager<UserAccount>>();
builder.Services.AddTransient<RoleManager<UserRole>, RoleManager<UserRole>>();
builder.Services.AddTransient<SignInManager<UserAccount>, SignInManager<UserAccount>>();

builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IFileSerivce, FileService>();
builder.Services.AddTransient<IPublishedBookService, PublishedBookService>();
builder.Services.AddTransient<IBookRequestService, BookRequestService>();
builder.Services.AddTransient<IStatisticService, StatisticService>();
builder.Services.AddTransient<IFeedBackService, FeedBackService>();
builder.Services.AddTransient<IBlogService, BlogService>();
builder.Services.AddTransient<ITopicService, TopicService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddMvc()
                .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryManagement.Api v1"));
}
app.UseCors("CORS");

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();

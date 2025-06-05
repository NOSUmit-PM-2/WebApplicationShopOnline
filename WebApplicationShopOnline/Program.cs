using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;

var builder = WebApplication.CreateBuilder(args);

string usersJsonPath = Path.Combine(builder.Environment.ContentRootPath, builder.Configuration["AppSettings:UsersJsonPath"]);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CartDBRepository>();
builder.Services.AddSingleton(new UserRepository(usersJsonPath));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

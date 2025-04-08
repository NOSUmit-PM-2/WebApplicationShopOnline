using WebApplicationShopOnline.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IUserRepository, UserRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/");
app.MapControllerRoute(
    name: "search",
    pattern: "{controller=User}/{action=Search}/");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Catalog}/");
app.Run();

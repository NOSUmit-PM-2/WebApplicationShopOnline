using Microsoft.EntityFrameworkCore;
using OnlineShop.DB;
using WebApplicationShopOnline.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<ProductsRepository>();
//builder.Services.AddSingleton<IProductsRepository, ProductsInJSONRepository>();
//builder.Services.AddSingleton<IProductsRepository, ProductsInMemoryRepository>();
builder.Services.AddSingleton<ICartRepository, CartsInMemoryRepository>();
string connection = builder.Configuration.GetConnectionString("DBonlineShop");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));
builder.Services.AddTransient<IProductDBsRepository, ProductsDBRepository>();

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

app.Run();

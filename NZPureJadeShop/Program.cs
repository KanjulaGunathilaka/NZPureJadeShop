using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using NZPureJadeShop.Models.Repository;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NZPureJadeShopDbContextConnection") ?? throw new InvalidOperationException("Connection string 'NZPureJadeShopDbContextConnection' not found.");

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IJadeRepository, JadeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<NZPureJadeShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:NZPureJadeShopDbContextConnection"]);
});

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<NZPureJadeShopDbContext>();

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddControllers();
var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();
//app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id:int?}");

app.MapRazorPages();

DbInitializer.Seed(app);

app.Run();

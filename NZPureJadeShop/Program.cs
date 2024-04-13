using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models;
using NZPureJadeShop.Models.IRepository;
using NZPureJadeShop.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IJadeRepository, JadeRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddDbContext<NZPureJadeShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:NZPureJadeShopDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id:int?}");

DbInitializer.Seed(app);

app.Run();

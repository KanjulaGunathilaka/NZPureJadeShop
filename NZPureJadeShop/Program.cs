using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models;

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

app.MapDefaultControllerRoute();

DbInitializer.Seed(app);

app.Run();

using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Data.Adapters;
using PetShop.Domain.Data.Context;
using PetShop.Domain.Data.Dtos;
using PetShop.Domain.Data.Models;
using PetShop.Domain.Repositories;
using PetShop.Domain.Services.Classes;
using PetShop.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("PetShopDbConnection");
builder.Services.AddDbContext<PetShopDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IQueryRepository<User>, QueryRepository<User>>();
builder.Services.AddScoped<ICommandRepository<User>, CommandRepository<User>>();
builder.Services.AddScoped<IBaseAdapter<User, UserDto>, UserAdapter>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

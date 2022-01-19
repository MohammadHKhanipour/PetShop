var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IQueryRepository<Pet>, QueryRepository<Pet>>();
builder.Services.AddScoped<ICommandRepository<Pet>, CommandRepository<Pet>>();
builder.Services.AddScoped<IBaseAdapter<Pet, PetDto>, PetAdapter>();
builder.Services.AddScoped<IPetService, PetService>();

builder.Services.AddIdentity<User, IdentityRole>(option =>
 {
     option.Password.RequiredUniqueChars = 0;
     option.Password.RequireUppercase = false;
     option.Password.RequireLowercase = false;
     option.Password.RequireNonAlphanumeric = false;
     option.Password.RequiredLength = 6;
     option.Lockout.MaxFailedAccessAttempts = 5;
 }).AddEntityFrameworkStores<PetShopDbContext>().AddDefaultTokenProviders();

var connectionString = builder.Configuration.GetConnectionString("PetShopDbConnection");
builder.Services.AddDbContext<PetShopDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

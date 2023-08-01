using Microsoft.EntityFrameworkCore;
using Web_App.Data;
using Web_App.Data.Services;
using Web_App.Models;

var builder = WebApplication.CreateBuilder(args);

//DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//services config
builder.Services.AddScoped<IActorsService, ActorsService>();

var app = builder.Build();

//seed db
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    AppDbInitializer.Seed(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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

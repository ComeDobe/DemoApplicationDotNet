using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register EFCoreDemoContext with the DI container
builder.Services.AddDbContext<EFCoreDemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFCoreDemoContexConnection")));

// After adding DbContext, print the connection string for debugging purposes.
Console.WriteLine($"Connection string retrieved: {builder.Configuration.GetConnectionString("EFCoreDemoContexConnection")}");

var app = builder.Build();

// Configure the HTTP request pipeline.
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

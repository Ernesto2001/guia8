using Microsoft.EntityFrameworkCore;
using guia8.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// aca se agrega
builder.Services.AddDbContext<GuiaDbContext>(opt =>
    opt.UseSqlServer(
            builder.Configuration.GetConnectionString("GuiaDbConnection")
        )
);

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

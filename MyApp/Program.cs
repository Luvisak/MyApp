using MyApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseExceptionHandler("/Home/Error"); // Asegúrate de tener una vista Error
app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");

app.UseStaticFiles();
app.UseRouting();

app.MapDefaultControllerRoute();
app.Run();

using ArtFusionStudio.DataAccess.Data;
using ArtFusionStudio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ArtFusionStudio.Data;
//using ArtFusionStudio.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ArtFusionStudioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ArtFusionStudioContext") ?? throw new InvalidOperationException("Connection string 'ArtFusionStudioContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddDbContext<ArtFusionStudioContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("ArtFusionStudioContext") ?? throw new InvalidOperationException("Connection string 'ArtFusionStudioContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

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
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();

using IdentityServer4WebApp.Data;
using IdentityServer4WebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();

builder.Services
       .AddDefaultIdentity<ApplicationUser>()
       .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services
       .AddIdentityServer()
       .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

builder.Services
       .AddAuthentication()
       .AddIdentityServerJwt();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseIdentityServer();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});

app.Run();

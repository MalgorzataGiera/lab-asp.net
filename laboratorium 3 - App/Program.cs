using Data1;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using laboratorium_3___App.Models;
using labolatorium_3___App.Models;

namespace laboratorium_3___App
{
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);
                var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

                // Add services to the container.
                builder.Services.AddControllersWithViews();
                //builder.Services.AddSingleton<IDateTimeProvidercs, CurrentDateTimeProvider>();
                builder.Services.AddRazorPages();
                builder.Services.AddSession();
                builder.Services.AddDbContext<AppDbContext>();

                builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<AppDbContext>();
                builder.Services.AddTransient<IContactService, EfContactService>();

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
            app.UseMiddleware<LastVisitCookie>(); 
                app.UseAuthentication(); ;
                app.UseAuthorization();
                app.UseSession();
                app.MapRazorPages();
                app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

                app.Run();
            }
        }
    }
using Eventy.BLL.Interfaces;
using Eventy.BLL.Repository;
using Eventy.DAL.Context;
using Eventy.DAL.Entities.EventModule;
using Eventy.DAL.Entities.UserModule;
using Eventy.DAL.Entities.VolunteerModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Eventy.PL.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"))
                );
            //.AddEntityFrameworkProxies()
            builder.Services.AddScoped<IGenericRepository<Catagory>,GenericRepository<Catagory>>();
            builder.Services.AddScoped<IGenericRepository<Commitee>, GenericRepository<Commitee>>();
            builder.Services.AddScoped<IGenericRepository<EventyEvent>, GenericRepository<EventyEvent>>();
            builder.Services.AddScoped<IGenericRepository<ApplicationUser>, GenericRepository<ApplicationUser>>();
            builder.Services.AddScoped<IGenericRepository<Volunteer>, GenericRepository<Volunteer>>();
            builder.Services.AddScoped<IGenericRepository<Application>, GenericRepository<Application>>();
            builder.Services.AddScoped<IGenericRepository<Rating>, GenericRepository<Rating>>();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                option =>
                {
                    option.Password.RequiredUniqueChars = 3;
                    option.Password.RequireLowercase = true;
                    option.Password.RequireUppercase = true;
                    option.SignIn.RequireConfirmedAccount = true;
                }).AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddRazorPages();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

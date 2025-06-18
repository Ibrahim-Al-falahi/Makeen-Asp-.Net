using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Todo.BLL.Interfaces;
using Todo.BLL.Repositories;
using Todo.DAL.Context;
using Todo.DAL.Entities;

namespace Todo.PL.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(
                option => option.UseSqlServer(builder.Configuration.GetConnectionString("Connection"))
                );
            builder.Services.AddScoped<IGenericRepository<Catagory>, GenericRepository<Catagory>>();
            builder.Services.AddScoped<IGenericRepository<TodoList>, GenericRepository<TodoList>>();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(
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

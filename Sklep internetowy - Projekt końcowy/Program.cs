
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Sklep_internetowy___Projekt_końcowy.Areas.Identity.Data;
namespace Sklep_internetowy___Projekt_końcowy
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

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
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Produkts}/{action=Index}/{id?}");

            using (var scope = app.Services.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var roles = new[] { "Admin", "Member" };

                foreach (var role in roles)
                {
                    if(!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            using (var scope = app.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                
                string email = "admin@admin.com";
                string password = "123Asd!";
                string firstName = "admin";
                string lastName = "admin";
                

                if (await userManager.FindByEmailAsync(email) == null)
                {
                    var admin = new ApplicationUser();
                    admin.Email = email;
                    admin.UserName = email;
                    admin.FirstName = firstName;
                    admin.LastName = lastName;
                   
                    

                    await userManager.CreateAsync(admin, password);
                    await userManager.AddToRoleAsync(admin, "Admin");
                }

                
            }

            using (var scope = app.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();


                string email = "test@test.com";
                string password = "Asd123!";
                string firstName = "test";
                string lastName = "test";


                if (await userManager.FindByEmailAsync(email) == null)
                {
                    var test = new ApplicationUser();
                    test.Email = email;
                    test.UserName = email;
                    test.FirstName = firstName;
                    test.LastName = lastName;



                    await userManager.CreateAsync(test, password);
                    await userManager.AddToRoleAsync(test, "Member");
                }


            }

            app.Run();
        }

    }

}

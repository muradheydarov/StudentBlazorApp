using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentBlazorApp.Data;

[assembly: HostingStartup(typeof(StudentBlazorApp.Areas.Identity.IdentityHostingStartup))]
namespace StudentBlazorApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StudentBlazorAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StudentBlazorAppContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<StudentBlazorAppContext>();
            });
        }
    }
}
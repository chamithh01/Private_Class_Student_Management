using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student_Management_System.Areas.Identity.Data;
using Student_Management_System.Data;

[assembly: HostingStartup(typeof(Student_Management_System.Areas.Identity.IdentityHostingStartup))]
namespace Student_Management_System.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Student_Management_SystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Student_Management_SystemContextConnection")));

                services.AddDefaultIdentity<Student_Management_SystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Student_Management_SystemContext>();
            });
        }
    }
}
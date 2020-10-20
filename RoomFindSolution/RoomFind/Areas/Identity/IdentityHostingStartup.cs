using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoomFind.Areas.Identity.Data;
using RoomFind.Data.Context;

[assembly: HostingStartup(typeof(RoomFind.Areas.Identity.IdentityHostingStartup))]
namespace RoomFind.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RoomFindContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RoomFindContextConnection")));

                services.AddDefaultIdentity<RoomFindUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RoomFindContext>();
            });
        }
    }
}
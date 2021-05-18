using System;
using BlazorRoleBasedSecuritySqlite.Server.Data;
using BlazorRoleBasedSecuritySqlite.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorRoleBasedSecuritySqlite.Server.Areas.Identity.IdentityHostingStartup))]
namespace BlazorRoleBasedSecuritySqlite.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
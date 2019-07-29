using E_Commerce.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    /// <summary>
    /// Sets up roles for users and adds those role to the Identity DB
    /// </summary>
    public class RoleInitializer
    {
        /// <summary>
        /// Creates new roles.
        /// </summary>
        private static readonly List<IdentityRole> Roles = new List<IdentityRole>()
        {
            new IdentityRole
            {
                Name = ApplicationRoles.Admin, NormalizedName = ApplicationRoles.Admin.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString()
            },

            new IdentityRole
            {
                Name = ApplicationRoles.Member, NormalizedName = ApplicationRoles.Member.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString()
            }

        };

        /// <summary>
        /// Makes sure the database is created and adds roles into that database.
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void SeedData(IServiceProvider serviceProvider)
        {
            using (var dbContext =
                new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                dbContext.Database.EnsureCreated();
                AddRoles(dbContext);
            }
        }

        /// <summary>
        /// Addes roles to the Roles table then saves changes.
        /// </summary>
        /// <param name="context"></param>
        private static void AddRoles(ApplicationDbContext context)
        {
            if (context.Roles.Any()) return;
            foreach (var role in Roles)
            {
                context.Roles.Add(role);
                context.SaveChanges();
            }
        }
    }
}

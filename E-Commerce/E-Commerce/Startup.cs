using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using E_Commerce.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;

            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string ConnectionString = Environment.IsDevelopment()
                ? Configuration.GetConnectionString("DefaultConnection")
                : Configuration.GetConnectionString("ProductionConnection");

            string UserConnectionString = Environment.IsDevelopment()
                ? Configuration.GetConnectionString("UserConnection")
                : Configuration.GetConnectionString("UserProductionConnection");

            services.AddDbContext<ECommDbContext>(options =>
            options.UseSqlServer(ConnectionString));


            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(UserConnectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                policy.RequireRole(ApplicationRoles.Admin));
            });

            //Registered Interfaces
            services.AddScoped<IInventory, InventoryManager>();
            services.AddScoped<IBasket, BasketManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();

        }
    }
}
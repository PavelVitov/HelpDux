using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.Repositories.Interfaces;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace HelpDux
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWebsiteRepository, WebsiteRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWebsiteService, WebsiteService>();
            services.AddScoped<IReviewService, ReviewService>();

            //DbContext
            services.AddDbContext<HelpDuxDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

using BusinessLayer.AutoMapper;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataLayer;
using DataLayer.Repositories;
using DataLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            //For MsSQL connection
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<HelpDuxDbContext>(options =>
                    options.UseSqlServer(connectionString));

            //Razor pages
            services.AddRazorPages();

            //Mapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

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

            //MVC
            services.AddControllersWithViews();

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
                endpoints.MapDefaultControllerRoute();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SebastianMortaLab6Zadanie.Interfaces;
using SebastianMortaLab6Zadanie.Mock;
using Microsoft.EntityFrameworkCore;
using SebastianMortaLab6Zadanie.Data;
using SebastianMortaLab6Zadanie.Data.Repositories;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using SebastianMortaLab6Zadanie.Models;


namespace SebastianMortaLab6Zadanie
{
    [System.Runtime.InteropServices.Guid("C1C7BF1E-57DB-40AC-841E-ECD7FD1159EA")]
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
       

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IFoodRepository, FoodRepository>();

            services.AddControllersWithViews();
            services.AddMvc();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            DbInitializer.Seed(app);
        }
    }
}

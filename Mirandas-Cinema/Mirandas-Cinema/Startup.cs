using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Cart;
using Mirandas_Cinema.Data.Repository;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema
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
            services.AddControllersWithViews();

            //Configuracion de DbContext
            services.AddDbContext<AppDbContext>(options => options.
            UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            //Configuracion de servicios
            services.AddScoped<IActors, ActorsRepository>();
            services.AddScoped<IMovies, MoviesRepository>();
            services.AddScoped<IOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(s => ShoppingCart.GetShoppingCart(s));

            //Autentificacion y autorizacion
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddMemoryCache();
            //Agregar sesion
            services.AddSession();
            services.AddAuthentication(options =>
            { 
                //Autenticacion de cookies
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
            
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
                app.UseExceptionHandler("NotFound");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();   

            //Autentificacion y autorizacion
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Movies}/{action=Index}/{id?}");
            });

            ////Modelos de semillas
            //AppDbInicializer.Seed(app);
            //AppDbInicializer.SeedUsers(app).Wait();
        }
    }
}

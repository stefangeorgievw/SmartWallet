using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartWaller.Infrastructure.IoC;
using SmartWallet.Web.Areas.Identity;
using SwartWallet.Infrastructure.Data.Context;
using SwartWallet.Infrastructure.Data.Models;

namespace SmartWallet.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private static void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterDependencies(services);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SmartWalletDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("SmartWalletConnection")));
            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<SmartWalletDbContext>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();

            RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

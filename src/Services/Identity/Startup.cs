using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Session;
using BPO.Model;
using Identity.Data;
using Microsoft.AspNetCore.Identity;
using Identity.Configuration;
using System.Collections.Generic;
using IdentityServer4.Services;
using Identity.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;

namespace Identity
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
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            // Add framework services.
            services.AddDbContext<BPOIdentityDbContext>(options =>
           options.UseSqlServer(connectionString));
            services.AddIdentity<User, Role>()
                        .AddEntityFrameworkStores<BPOIdentityDbContext>()
                        .AddDefaultTokenProviders();
            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
               .AddCookie(o => o.LoginPath = new PathString("/account/login")).AddOpenIdConnect();
            //Microsoft.AspNetCore.Authentication.IAuthenticationService
    
            services.Configure<AppSettings>(Configuration);
            services.AddDataProtection(opts =>
            {
                opts.ApplicationDiscriminator = "bpo.identity";
            });
            services.AddMvc();
 
            services.AddSession();
            services.AddTransient<IRedirectService, RedirectService>();
            Dictionary<string, string> clientUrls = new Dictionary<string, string>();
            clientUrls.Add("Mvc", Configuration.GetValue<string>("MvcClient"));
            clientUrls.Add("Spa", Configuration.GetValue<string>("SpaClient"));
            clientUrls.Add("Xamarin", Configuration.GetValue<string>("XamarinCallback"));
            services.AddIdentityServer(options =>
            {
                options.Authentication.FederatedSignOutPaths.Add("/signout-callback-aad");
                options.Authentication.FederatedSignOutPaths.Add("/signout-callback-idsrv");
                options.Authentication.FederatedSignOutPaths.Add("/signout-callback-adfs");

                options.Events.RaiseSuccessEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseErrorEvents = true;
            })
                 .AddInMemoryClients(Config.GetClients(clientUrls))
     .AddSigningCredential(Certificate.Get())
     .AddInMemoryApiResources(Config.GetApis())
     .AddInMemoryIdentityResources(Config.GetResources())
     .Services.AddTransient<IProfileService, ProfileService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

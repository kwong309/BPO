using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using BPO.Core;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using CMS.MVC.Services;
using CMS.MVC.Filters;
using CMS.MVC.Data;

namespace CMS.MVC
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

            WebConfigUtils.IsNeedInstall = Configuration.GetValue<bool>("IsNeedInstall");
            WebConfigUtils.IsProtectData = Configuration.GetValue<bool>("IsProtectData");
            WebConfigUtils.SecretKey = Configuration.GetValue<string>("SecretKey");
            WebConfigUtils.DatabaseType = Configuration.GetValue<EDatabaseType>("DatabaseType");
            WebConfigUtils.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
            if (WebConfigUtils.IsProtectData)
            {
                WebConfigUtils.ConnectionString = TranslateUtils.Decrypt(WebConfigUtils.ConnectionString);
            }
                WebConfigUtils.AdminDirectory = Configuration.GetValue<string>("AdminDirectory");
            if (WebConfigUtils.IsNeedInstall)
            {

            }
            else
            {
                if(WebConfigUtils.DatabaseType== EDatabaseType.MySql)
                {
                    services.AddEntityFrameworkMySql().AddDbContext<CMS.MVC.Data.CMSDB>(options =>options.UseMySql(WebConfigUtils.ConnectionString));
                }
                else
                {
                    services.AddDbContext<CMS.MVC.Data.CMSDB>(options => options.UseSqlServer(WebConfigUtils.ConnectionString)).AddEntityFrameworkSqlServer();
                }
                services.AddAuthentication(sharedOptions =>
                {
                    sharedOptions.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    sharedOptions.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    sharedOptions.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                }).AddCookie(o =>
                {
                    o.Cookie.HttpOnly = true;
                    o.Cookie.Name = "cms";
                    o.LoginPath = new PathString("/account/login");
                });
            }
            services.AddTransient<VierificationCodeService>();
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddMvc(o => { o.Filters.Add(typeof(HttpGlobalExceptionFilter)); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            WebConfigUtils.ContentRootPath = env.ContentRootPath;
            WebConfigUtils.WebRootPath= env.WebRootPath;
            if (WebConfigUtils.IsNeedInstall)
            {

            }
            else
            {
                if (WebConfigUtils.DatabaseType == EDatabaseType.MySql)
                {
  
                }
                else
                {

                }
                app.UseAuthentication();
            }
            app.UseStaticHttpContext();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                if (WebConfigUtils.IsNeedInstall)
                {
                    routes.MapRoute(
                    name: "default",
                    template: "{controller=Installer}/{action=Index}/{id?}");
                }
                else
                {
                    routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                }

            });
            //DbContextOptionsBuilder<CMSDB> dbContextOptionsBuilder = new DbContextOptionsBuilder<CMSDB>();
            //Action<DbContextOptionsBuilder<CMSDB>> optionsAction = options => dbContextOptionsBuilder=options.UseSqlServer<CMSDB>(WebConfigUtils.ConnectionString);
            //optionsAction.Invoke(dbContextOptionsBuilder);
            
            //CMSDB db = new CMSDB(dbContextOptionsBuilder.Options);
 
            //context.Database.Migrate();

        }
    }
}

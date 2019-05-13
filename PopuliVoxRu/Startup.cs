using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PopuliVoxRu.Domain.Core.Extensions;
using PopuliVoxRu.Domain.Core.Models.Identity;
using PopuliVoxRu.Domain.Core.Utils;
using PopuliVoxRu.Infrastructure.Data.Context;

namespace PopuliVoxRu
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
            // For easy access to configuration via injection of IConfiguration:
            services.AddSingleton(_ => Configuration);

            services.AddInjection();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Entity framework:
            services.AddDbContext<PopuliVoxRuWebContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("populivox_web")));

            services.AddDbContext<PopuliVoxRuIdentityContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("populivox_identity")));

            // Identity:
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<PopuliVoxRuIdentityContext>()
                .AddDefaultTokenProviders();

            // Auto mapper configuration and init:
            MapperConfiguration mappingConfig =
                new MapperConfiguration(config =>
                {
                    config.AddProfile(new DomainMappingProfiles());
                });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Home/Error");
                //app.UseHsts();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseAuthentication();
            app.UseDefaultFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

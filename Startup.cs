using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using a101_backend.Services.AuthService;
using a101_backend.Services.CompanyService;
using a101_backend.Services.PartnerInfoService;

namespace a101_backend
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
            // Services Registrations
            /*
            services.AddScoped<IApartmentService, ApartmentService>(); // apartments service
            services.AddScoped<IUserService, UserService>(); // users service
            services.AddScoped<IRoomService, RoomService>(); // rooms service
            services.AddScoped<IFStorageService, FStorageService>(); // fstorages service
            services.AddScoped<IFStorageStillageService, FStorageStillageService>(); // fstoragestillages sevice
            services.AddScoped<IAuthService, AuthService>(); // auth service
            services.AddScoped<IFSSTypeService, FSSTypeService>(); // stillage types service
            services.AddScoped<IProductService, ProductService>();
            */

            // Резервирование сервиса авторизации
            services.AddScoped<IAuthService, AuthService>();
            // Резервирование сервиса компаний
            services.AddScoped<ICompanyService, CompanyService>();
            // Резервирование сервиса информации о партнере
            services.AddScoped<IPartnerInfoService, PartnerInfoService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

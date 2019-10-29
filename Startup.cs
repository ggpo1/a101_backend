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
using a101_backend.Services.UserService;
using a101_backend.Services.CityService;
using a101_backend.Services.DocumentService;
using a101_backend.Services.DealService;
using a101_backend.Services.CompanyStatusService;

namespace a101_backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
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

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(
                        "http://localhost:8080", 
                        "http://192.168.50.8:10101", 
                        "http://192.168.50.8",
                        "http://localhost:8081",
                        "http://192.168.50.8:11111"
                        );
                    builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
                });
            });

            // Резервирование сервиса авторизации
            services.AddScoped<IAuthService, AuthService>();
            // Резервирование сервиса компаний
            services.AddScoped<ICompanyService, CompanyService>();
            // Резервирование сервиса информации о партнере
            services.AddScoped<IPartnerInfoService, PartnerInfoService>();
            // Резервирование сервиса юзеров
            services.AddScoped<IUserService, UserService>();
            // Резервирование сервиса городов
            services.AddScoped<ICityService, CityService>();
            // Резервирование сервиса документов
            services.AddScoped<IDocumentService, DocumentService>();
            // Резервирование сервиса для интеграции amoCrm
            services.AddScoped<IDealService, DealService>();
            // Резервирование сервиса для статусов сделки
            services.AddScoped<ICompanyStatusService, CompanyStatusService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/myapp-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

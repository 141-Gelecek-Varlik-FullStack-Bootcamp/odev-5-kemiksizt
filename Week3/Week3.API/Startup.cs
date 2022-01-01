using AutoMapper;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week3.API.Infrastructure;
using Week3.Service.Category;
using Week3.Service.Job;
using Week3.Service.Product;
using Week3.Service.User;

namespace Week3.API
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
            var _mappingProfile = new MapperConfiguration(mp => { mp.AddProfile(new MappingProfile()); });
            IMapper mapper = _mappingProfile.CreateMapper();

            services.AddSingleton(mapper);

            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<ICategoryService, CategoryService>();

            services.AddStackExchangeRedisCache(options => options.Configuration = "localhost:6379");

            services.AddScoped<LoginFilter>();

            services.AddHangfire(config =>
                config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                        .UseSimpleAssemblyNameTypeSerializer()
                        .UseDefaultTypeSerializer()
                        .UseMemoryStorage());

            services.AddHangfireServer();
            services.AddSingleton<IWelcomeJob, WelcomeJob>();

            services.AddMemoryCache();
            services.AddControllers();
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Week3.API", Version = "v1" });
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                              IWebHostEnvironment env,
                              IBackgroundJobClient backgroundJobClient,
                              IRecurringJobManager recurringJobManager,
                              IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Week3.API v1"));

            }
            
            app.UseHttpsRedirection();

            app.UseHangfireDashboard();

            backgroundJobClient.Enqueue(() => serviceProvider.GetService<IWelcomeJob>().PrintWelcome());

            recurringJobManager.AddOrUpdate(
                "Run every minute",
                () => new WelcomeJob().PrintWelcome(),
                "* * * * *"
                );

            recurringJobManager.AddOrUpdate(
                "WelcomeEmail",
                () => serviceProvider.GetService<IWelcomeJob>().SendEmail(),
                "* * * * * "
                );


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                    
            });
        }
    }
}

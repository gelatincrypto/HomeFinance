using HomeFinance.Api.Extension;
using HomeFinance.Infrastructure.Data;
using HomeFinance.Infrastructure.Data.Interfaces;
using HomeFinance.Infrastructure.Data.Repository;
using HomeFinance.Services.Business.Interfaces;
using HomeFinance.Services.Business.Manager;
using HybridModelBinding;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HomeFinance.Api
{
    public class Startup
    {
        public Startup(IHostEnvironment environment)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HomeFinanceContext>(options =>
            {
                options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(Configuration["Data:HomeFinanceDb:ConnectionString"]);
            });
            services.AddMvc(option => option.EnableEndpointRouting = false)
                    .AddHybridModelBinder(options => options.FallbackBindingOrder = new[] { Source.Route, Source.Body });
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IOperationRepository, OperationRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOperationManager, OperationManager>();
            services.AddTransient<IReportManager, ReportManager>();
            services.AddAutoMapperSingleton();
            services.AddControllers();
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, HomeFinanceContext dataContext, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseCustomExceptionHandler();
            }

            app.MigrateIfNotExist(dataContext, logger);
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}

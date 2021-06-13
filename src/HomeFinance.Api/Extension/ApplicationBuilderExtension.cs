using System;
using HomeFinance.Services.Business.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace HomeFinance.Api.Extension
{
    public static class ApplicationBuilderExtension
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(a => a.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature.Error;
                context.Response.StatusCode = exception switch
                {
                    CategoryAlreadyExistException _ => Status400BadRequest,
                    CategoryNotFoundException _ => Status404NotFound,
                    _ => context.Response.StatusCode
                };

                var result = JsonConvert.SerializeObject(new { error = exception.Message });
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(result);
            }));
        }


        public static void MigrateIfNotExist(this IApplicationBuilder app, DbContext dataContext, ILogger<Startup> logger)
        {

            try
            {
                logger.LogInformation("Start migration");
                dataContext.Database.Migrate();
                logger.LogInformation("End migration");
            }
            catch (Exception e)
            {
                logger.LogError("Migration failed");
                logger.LogError(e.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Diagnostics;
using PaymentApiDotnet.Entities.Exceptions;
using PaymentApiDotnet.Entities.Models.ErrorModel;
using PaymentApiDotnet.Services.Logger;
using System.Net;

namespace PaymentApiDotnet.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
        {
            app.UseExceptionHandler(appError =>
            {
                // async method 
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if(contextFeature is not null) // if error exist
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,
                            _ => StatusCodes.Status500InternalServerError
                        };

                        logger.LogError($"Something went wrong : {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        { 
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        }
                        .ToString());
                    }
                });
            });
        }
    }
}

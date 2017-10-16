using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreStart
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Authorization
    {
        private readonly RequestDelegate _next;

        public Authorization(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.WriteAsync("Authorization complete");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthorizationExtensions
    {
        public static IApplicationBuilder UseAuthorization(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Authorization>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TravelBlog.Views.Shared
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class _Layout
    {
        private readonly RequestDelegate _next;

        public _Layout(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class _LayoutExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<_Layout>();
        }
    }
}

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace App.chamchas.infraestructura.Api.Mediator
{
    public class MiddlewareCanchas
    {
        private readonly RequestDelegate _next;
        public MiddlewareCanchas(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {

                await HandleGlobalExceptionAsync(httpContext, ex);
            }
        }
        private static Task HandleGlobalExceptionAsync(HttpContext context, Exception exception)
        {
            return context.Response.WriteAsync("Errors");
        }
    }
}

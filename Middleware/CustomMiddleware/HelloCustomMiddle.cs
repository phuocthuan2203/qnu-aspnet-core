using System;

namespace Middleware.CustomMiddleware;

public class HelloCustomMiddleware
{
    private readonly RequestDelegate _next;

    public HelloCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if(context.Request.Query.ContainsKey("firstName") && context.Request.Query.ContainsKey("lastName")) {
            string? firstName = context.Request.Query["firstName"];
            string? lastName = context.Request.Query["lastName"];
            await context.Response.WriteAsync($"\nHello {firstName} {lastName}");
        }
        await _next(context);
    }

}

public static class HelloCustomMiddlewareExtension
{
    public static IApplicationBuilder UseHelloCustomMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<HelloCustomMiddleware>();
    }
}
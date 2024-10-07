using System;

namespace ReviewMiddleware.CustomMiddleware;

public class HelloCustomMiddleware
{
    private readonly RequestDelegate _next;

    // the subsequent middleware is passed as an argument
    public HelloCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if(context.Request.Query.ContainsKey("firstname") && context.Request.Query.ContainsKey("lastname"))
        {
            string? firstname = context.Request.Query["firstname"];
            string? lastname = context.Request.Query["lastname"];
            await context.Response.WriteAsync($"Hello {firstname} {lastname}!!!\n");
        }

        await _next(context);
    }

}

// HelloCustomMiddleware extension method
public static class HelloCustomMiddlewareExtension
{
    public static IApplicationBuilder UseHelloCustomMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<HelloCustomMiddleware>();
    }
}

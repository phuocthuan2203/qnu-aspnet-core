using System;

namespace Middleware.CustomMiddleware;

public class MyCustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("\nMy Custom Middleware - Start");
        await next(context);
        await context.Response.WriteAsync("\nMy Custom Middleware - End");
    }
}

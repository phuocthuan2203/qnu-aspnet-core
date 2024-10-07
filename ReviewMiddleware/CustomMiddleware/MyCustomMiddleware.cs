
namespace ReviewMiddleware.CustomMiddleware;

public class MyCustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("\nMy CustomMiddleware - Starts");
        await next(context);
        await context.Response.WriteAsync("\nMy CustomMiddleware - Ends");
    }
}

public static class CustomMiddlewareExtension {
    public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app) {
        return app.UseMiddleware<MyCustomMiddleware>();
    }
}
using Middleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();

var app = builder.Build();

// middleware 1
// we can just use 'context' instead of 'HttpContext context' and 'next' instead of 'RequestDelegate next'
app.Use(async (context, next) => {
    await context.Response.WriteAsync("From Middleware 1");
    await next(context);
});

// middleware 2
// app.UseMiddleware<MyCustomMiddleware>();
app.UseMyCustomMiddleware();

// middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nFrom Middleware 3");
});

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// middleware 1
// we can just use 'context' instead of 'HttpContext context' and 'next' instead of 'RequestDelegate next'
app.Use(async (context, next) => {
    await context.Response.WriteAsync("Hello World!");
    await next(context);
});

// middleware 2
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("\nHello World!");
    await next(context);
});

// middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nHello World Again!");
});

app.Run();

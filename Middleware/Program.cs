var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello World!");
});

app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello World Again!");
});

app.Run();

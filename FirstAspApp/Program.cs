var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    context.Response.StatusCode = 200;

    // write the content to the response body
    await context.Response.WriteAsync("Hello World!");
});

app.Run();

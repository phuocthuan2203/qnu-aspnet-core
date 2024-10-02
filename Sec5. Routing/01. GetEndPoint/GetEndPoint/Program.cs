var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// First custom middleware
app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
    {
        await context.Response.WriteAsync($"Endpoint: {endPoint.DisplayName}\n");
    }
    await next(context); // Calls the next middleware
    // No code here, so it doesn't do anything after the next middleware completes
});

app.UseRouting();

// Second custom middleware
app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
    {
        await context.Response.WriteAsync($"Endpoint: {endPoint.DisplayName}\n");
    }
    await next(context); // Calls the next middleware
    // No code here, so it doesn't do anything after the next middleware completes
});

app.UseEndpoints(endpoints =>
{
    //add your endpoints here
    endpoints.MapGet("map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });

    endpoints.MapPost("map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});
app.Run();
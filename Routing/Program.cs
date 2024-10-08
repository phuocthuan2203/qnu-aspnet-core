var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) => {
    Endpoint? endpoint = context.GetEndpoint();
    if(endpoint is not null) {
        await context.Response.WriteAsync($"Endpoint: {endpoint.DisplayName}");
    }
    await next(context);
});

// enable routing
app.UseRouting();

app.Use(async (context, next) => {
    Endpoint? endpoint = context.GetEndpoint();
    if(endpoint is not null) {
        await context.Response.WriteAsync($"Endpoint: {endpoint.DisplayName}");
    }
    await next(context);
});

// define endpoints
app.UseEndpoints(endpoints => {
    endpoints.MapGet("map1", async (context) => {
        await context.Response.WriteAsync("Hello from map1");
    });

     endpoints.MapPost("map2", async (context) => {
        await context.Response.WriteAsync("Hello from map2");
    });
});

app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();

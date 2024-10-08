var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// enable routing
app.UseRouting();

// define endpoints
app.UseEndpoints(endpoints => {
    endpoints.Map("/files/{FileName}.{Extension}", async context => {
        string? filename = context.Request.RouteValues["filename"] as string;
        string? extension = context.Request.RouteValues["extension"] as string;
        await context.Response.WriteAsync($"In file {filename} - {extension}");
    });

    endpoints.Map("employee/profile/{name=thuan}", async context => {
        string? name = context.Request.RouteValues["name"] as string;
        await context.Response.WriteAsync($"Name: {name}");
    });
});

app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();

using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions() {
    WebRootPath = "myroot"
});
var app = builder.Build();

app.UseStaticFiles(); // works with myroot

app.UseStaticFiles(new StaticFileOptions() {
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "mywebroot"))
}); // works with mywebroot, ContentRootPath = /Users/thuannguyenphuoc/Library/CloudStorage/OneDrive-Personal/Document/08_ASPdotNET/Practices/WWWRootAndStaticFiles/

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.Map("/", async context => {
        await context.Response.WriteAsync("Hello World!");
    });
});

app.Run();

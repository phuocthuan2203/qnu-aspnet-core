var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    // how to set the status code of the response
    // context.Response.StatusCode = 200;
    // await context.Response.WriteAsync("Hello World!"); // write the content to the response body

    // how to set the headers of the response
    // context.Response.Headers["MyKey"] = "my key";
    // context.Response.Headers["Server"] = "My Server";
    // context.Response.Headers["Content-Type"] = "text/html";
    // await context.Response.WriteAsync("<h1>Hello</h1>");
    // await context.Response.WriteAsync("<h2>World</h2>");

    // how to get the information of the request
    // var path = context.Request.Path;
    // var method = context.Request.Method;
    // context.Response.Headers["Content-Type"] = "text/html";
    // await context.Response.WriteAsync($"<p>Path: {path}</p>");
    // await context.Response.WriteAsync($"<p>Method: {method}</p>");

    // how to get the values of the query string
    // context.Response.Headers["Content-Type"] = "text/plain";
    // if(context.Request.Method == "GET") {
    //     if(context.Request.Query.ContainsKey("name")) {
    //         var name = context.Request.Query["name"];
    //         await context.Response.WriteAsync($"Hello, {name}!");
    //     }
    // }

    // get the headers information from request
    if(context.Request.Headers.ContainsKey("User-Agent")) {
        var userAgent = context.Request.Headers["User-Agent"];
        context.Response.Headers["Content-Type"] = "text/plain";
        await context.Response.WriteAsync($"User-Agent: {userAgent}");
    }
});

app.Run();

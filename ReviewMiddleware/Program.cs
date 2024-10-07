using ReviewMiddleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();

var app = builder.Build();

// middleware 1
app.Use(async (context, next) => {
    await context.Response.WriteAsync("Middleware 1!\n");
    await next(context);
    
    // await context.Response.WriteAsync("Middleware 1 finished!\n");
});

// middleware 2
// app.Use(async (context, next) => {
//     await context.Response.WriteAsync("Middleware 2!\n");
//     await next(context);
    
//     await context.Response.WriteAsync("Middleware 2 finished!\n");
// });
// app.UseMiddleware<MyCustomMiddleware>();
// app.UseMyCustomMiddleware();
app.UseHelloCustomMiddleware();

// middleware 3
app.Run(async (context) => {
    await context.Response.WriteAsync("Middleware 3!\n");
    
    // await context.Response.WriteAsync("Middleware 3 finished!\n");
});

app.Run();

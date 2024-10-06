var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) => {
    await context.Response.WriteAsync("Middleware 1!\n");
    await next(context);
    
    await context.Response.WriteAsync("Middleware 1 finished!\n");
});

app.Use(async (context, next) => {
    await context.Response.WriteAsync("Middleware 2!\n");
    await next(context);
    
    await context.Response.WriteAsync("Middleware 2 finished!\n");
});

app.Run(async (context) => {
    await context.Response.WriteAsync("Middleware 3!\n");
    
    await context.Response.WriteAsync("Middleware 3 finished!\n");
});

app.Run();

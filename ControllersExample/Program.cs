var builder = WebApplication.CreateBuilder(args); // initialize a new instance of the web application builder -> this sets up necessary services and configurations for the app

builder.Services.AddControllers(); // register MVC controller services with the DI container -> app can use controllers to handle incoming HTTP requests

var app = builder.Build(); // compile services and configurations into a web application instance -> the app is ready to handle requests

// step 2: enable routing
// first way
// app.UseRouting();
// app.UseEndpoints(endpoints => {
//     endpoints.MapControllers(); // detect and enable routing for all action methods
// });

// second way
app.MapControllers(); // setup the routing for app, scan the registered controllers and map their action methods to the appropriate routes based on the attributes defined in the controllers

app.Run();

# Practice03 - ASP.NET Core MVC Movie App

## Resources
https://learn.microsoft.com/vi-vn/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-8.0&tabs=visual-studio-code

https://learn.microsoft.com/vi-vn/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-8.0&tabs=visual-studio-code

## Project Overview

Practice03 is an ASP.NET Core MVC application that demonstrates the basics of building a web app for managing a movie database. This project is likely part of a learning exercise or tutorial for ASP.NET Core development.

## Features

- Movie listing
- CRUD operations for movies (Create, Read, Update, Delete)
- Basic styling using Bootstrap
- Database integration using Entity Framework Core

## Technology Stack

- ASP.NET Core 8.0
- Entity Framework Core
- SQLite Database
- Bootstrap 5.1.0
- jQuery 3.5.1

## Project Structure

The project follows a standard ASP.NET Core MVC structure:

- `Controllers/`: Contains MVC controllers
- `Models/`: Defines data models and database context
- `Views/`: Houses Razor views for the user interface
- `wwwroot/`: Static files (CSS, JavaScript, images)

## Key Components

### Program.cs

The entry point of the application, where services are configured and the app is built.

csharp:Program.cs
startLine: 1
endLine: 41

### Database Configuration

The project uses SQLite as the database, configured in the `Program.cs` file.

### Models

The `Movie` model is likely defined to represent movie data in the application.

### Views

Various views are set up for different pages:

- Home
- Movies (Index, Create, Edit, Delete, Details)
- Shared layouts

### Static Files

Bootstrap and jQuery are included for frontend styling and functionality.

## Getting Started

1. Ensure you have the .NET 8.0 SDK installed.
2. Clone the repository.
3. Navigate to the project directory.
4. Run `dotnet restore` to restore dependencies.
5. Run `dotnet run` to start the application.

## Development

This project uses hot reload for development. You can make changes to the code and see them reflected immediately without restarting the application.

## Database Seeding

The application includes a data seeding mechanism:
csharp:Program.cs
startLine: 15
endLine: 20

This ensures that initial data is populated in the database when the application starts.

## Styling

The application uses Bootstrap for styling, with custom styles defined in:
wwwroot/css/site.css


## JavaScript

Custom JavaScript can be added in:
wwwroot/js/site.js


## Contributing

This project appears to be a practice or learning exercise. If you're looking to contribute or extend it, consider adding more features, improving the UI, or enhancing the data model.

## License

No specific license information is provided in the given codebase. If this is a personal or educational project, consider adding an appropriate open-source license if you plan to share it publicly.
# ASPDAY2: ASP.NET Core Web Application with Data Persistence

`ASPDAY2` is an ASP.NET Core MVC web application, likely serving as a follow-up exercise to `ASPDAY1`. This project demonstrates how to integrate data persistence using Entity Framework Core with SQL Server, building upon foundational web development concepts.

## Features

-   **Web Application Structure:** Implements the Model-View-Controller (MVC) pattern.
-   **Data Persistence:** Integrates with SQL Server using Entity Framework Core for data storage and retrieval.
-   **Database Migrations:** Supports database schema evolution using EF Core Migrations.
-   **Frontend Styling:** Utilizes Bootstrap for responsive and modern UI components.
-   **Task-Specific Functionality:** (Assumed based on name) Likely includes features related to a specific task or data management scenario.

## Technologies Used

-   **ASP.NET Core MVC:** Web framework for building robust web applications.
-   **.NET 8.0:** The latest version of the .NET platform.
-   **C#:** The primary programming language.
-   **Entity Framework Core:** Object-Relational Mapper (ORM) for database interaction with SQL Server.
-   **Bootstrap 5.3.3:** Frontend framework for styling and responsive design.
-   **HTML, CSS, JavaScript:** For front-end development.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

-   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
-   [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (Community Edition is free) or [Visual Studio Code](https://code.visualstudio.com/) with C# extension.
-   [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or a local SQL Server instance.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/MemaroX/ASPDAY2.git
    cd ASPDAY2
    ```

2.  **Restore NuGet packages:**
    ```bash
    dotnet restore
    ```

3.  **Configure Database Connection:**
    Open `appsettings.json` and update the `ConnectionStrings` section to point to your SQL Server instance.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ASPDAY2Db;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```
    Adjust `Server` and `Database` as per your SQL Server setup.

4.  **Apply Database Migrations:**
    Open a terminal in the project root directory (`ASPDAY2`) and run the following commands to create and apply the database schema:
    ```bash
    dotnet ef database update
    ```

### Running the Application

1.  **From the project root directory (`ASPDAY2`):**
    ```bash
    dotnet run
    ```

2.  **Open in browser:**
    The application will typically launch in your default web browser at `https://localhost:7000` or `http://localhost:5000` (check the console output for the exact URL).

## Project Structure

```
ASPDAY2/
├── Controllers/        # Handles incoming HTTP requests and user input
├── Models/             # Data models and business entities
├── Properties/         # Project properties
├── Views/              # UI templates (Razor views)
├── wwwroot/            # Static files (CSS, JS, images)
├── appsettings.json    # Application configuration
├── appsettings.Development.json # Development-specific configuration
├── Program.cs          # Application entry point (.NET 6+ minimal APIs)
├── ASPDAY2.csproj      # Project file (defines dependencies, target framework)
├── ASPDAY2.sln         # Visual Studio Solution file
```

## Contributing

Contributions are welcome! If you have suggestions for improvements, bug fixes, or new features, please feel free to:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/YourFeatureName`).
3.  Make your changes.
4.  Commit your changes (`git commit -m 'Feat: Add YourFeature'`).
5.  Push to the branch (`git push origin feature/YourFeatureName`).
6.  Open a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

MemaroX - [Your GitHub Profile Link](https://github.com/MemaroX)

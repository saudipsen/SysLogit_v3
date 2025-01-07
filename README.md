# SysLogit_v3

# SysLogit - Logistics Management System

## Overview
SysLogit is a Windows Forms application built with .NET Framework 4.7.2 that manages logistics operations, including product inventory and shipment tracking. The application uses Entity Framework 6.5.1 for data access and Unity for dependency injection.

## System Requirements
- .NET Framework 4.7.2
- SQL Server Express
- Visual Studio 2019 or later

## Architecture

### Technology Stack
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **ORM**: Entity Framework 6.5.1
- **DI Container**: Unity 5.11.10
- **Database**: SQL Server Express

### Nuget Packages
- Closed XML

### Project Structure
```
SysLogit/
├── Business/
│   ├── Contracts/         # Interface definitions
│   └── Services/          # Business logic implementation
├── Data/
│   └── AppDbContext.cs    # EF DbContext configuration
├── Models/                # Domain model classes
├── Repository/           
│   ├── Interfaces/        # Repository interfaces
│   └── Implementations/   # Repository implementations
├── Unity/
│   └── UnityConfig.cs     # DI container configuration
└── Forms/                 # Windows Forms
```

### Design Patterns
- Repository Pattern
- Dependency Injection
- Unit of Work (via Entity Framework)

## Features

### Product Management
- Product inventory tracking
- Stock level monitoring
- Product details management

### Shipment Management
- Shipment creation and tracking
- Automated tracking number generation
- Shipment status updates

## Database Setup

### Connection String
The application uses SQL Server with the following default connection string in App.config:
```xml
<connectionStrings>
    <add name="ShipmentDb"
         connectionString="Server=LAPTOP-EAQ3VI5G\SQLEXPRESS;Database=logistic_dev;Uid=<provide user id>;Pwd=<provide password>;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Database Migration
The project uses Entity Framework Code First approach. To set up the database:

1. Open Package Manager Console
2. Run the following commands:
```
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

## Dependencies
Main project dependencies (packages.config):
```xml
<packages>
  <package id="EntityFramework" version="6.5.1" targetFramework="net472" />
  <package id="System.Runtime.CompilerServices.Unsafe" version="4.5.2" targetFramework="net472" />
  <package id="Unity" version="5.11.10" targetFramework="net472" />
</packages>
```

## Testing
The project includes a comprehensive test suite using:
- NUnit (3.13.3)
- NUnit3TestAdapter
- Moq (4.18.4)

### Test Structure
```
SysLogit.Tests/
├── Business/            # Business layer tests
├── Repository/          # Repository layer tests
└── Integration/         # Integration tests
```

### Running Tests
1. Install test packages in the test project only
2. Use Test Explorer in Visual Studio to run tests
3. Tests can also be run via command line: `dotnet test`

## Development Setup

1. Clone the repository
```bash
git clone [repository-url]
```

2. Open SysLogit.sln in Visual Studio

3. Update the connection string in App.config to match your SQL Server instance

4. Restore NuGet packages
```bash
nuget restore SysLogit.sln
```

5. Run database migrations
```
Update-Database
```

6. Build and run the application

## Code Style and Conventions

### Naming Conventions
- PascalCase for class names and public members
- camelCase for private fields
- Prefix private fields with underscore (_)
- Use meaningful and descriptive names

### Best Practices
- Follow SOLID principles
- Use async/await for database operations
- Implement proper exception handling
- Use dependency injection
- Write unit tests for new features

## Contributing

1. Create a feature branch
2. Make your changes
3. Write/update tests
4. Submit a pull request

## Error Handling
The application implements a centralized error handling system with:
- Business logic validation
- Database error handling
- User-friendly error messages
- Logging (when implemented)

## Security
- Connection string uses SQL authentication
- Sensitive data is not logged
- Input validation on all forms

## Future Improvements
- Implement logging system
- Add user authentication
- Enhanced reporting features
- Real-time tracking updates
- Email notifications
- Dashboard with analytics

## License
NA

## Contact
Saudip Sen

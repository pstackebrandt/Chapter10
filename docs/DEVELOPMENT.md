# Development Guidelines

## Setup Instructions

### Prerequisites
- .NET 9.0 SDK
- Visual Studio 2022 or later
- SQL Server (LocalDB or full instance)
- Git

### Initial Setup
1. Clone the repository
2. Restore NuGet packages
3. Update connection strings in appsettings.json
4. Run database migrations

## Coding Standards

### C# Guidelines
- Follow Microsoft C# Coding Conventions
- Use meaningful variable and method names
- Keep methods focused and small
- Add XML documentation for public APIs

### Entity Framework Core
- Use async/await for database operations
- Implement proper error handling
- Use transactions where appropriate
- Optimize queries for performance

## Git Workflow
1. Create feature branch from main
2. Make changes and commit
3. Create pull request
4. Code review
5. Merge to main

## Testing
- Write unit tests for business logic
- Implement integration tests for data access
- Use xUnit for testing framework
- Maintain good test coverage

## Code Review Checklist
- [ ] Code follows standards
- [ ] Tests are written/updated
- [ ] Documentation is updated
- [ ] Performance is considered
- [ ] Security is addressed

## Troubleshooting
- Check connection strings
- Verify database migrations
- Review Entity Framework logs
- Check for deadlocks 
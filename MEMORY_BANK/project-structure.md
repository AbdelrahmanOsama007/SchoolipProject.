# Project Structure

## Architecture Overview
Clean Architecture with CQRS pattern using MediatR

## Project Layers

### SchoolipProject.api/
- **Purpose**: Main API project (controllers, Program.cs, DI setup)
- **Key Files**:
  - `Program.cs` - Application startup and DI configuration
  - `Controllers/` - API endpoints
  - `appsettings.json` - Configuration

### SchoolipProject.Core/
- **Purpose**: Core logic, features, handlers, queries
- **Key Folders**:
  - `Features/` - Feature-based organization
  - `Student/` - Student-related features
  - `Queries/` - Query handlers and models
  - `Commands/` - Command handlers and models

### SchoolipProject.Service/
- **Purpose**: Service layer (interfaces and implementations)
- **Key Files**:
  - `Iservice/` - Service interfaces
  - `Service/` - Service implementations

### SchoolipProject.Infrastructure/
- **Purpose**: Data access, repositories
- **Key Folders**:
  - `Repository/` - Repository implementations
  - `Irepository/` - Repository interfaces

### SchoolipProject.Data/
- **Purpose**: Data entities and DbContext
- **Key Files**:
  - `Entities/` - Domain entities
  - `DbContext1.cs` - Entity Framework context

## Dependency Injection Setup
- **Location**: `SchoolipProject.api/Program.cs`
- **Pattern**: Interface-based registration
- **Lifetime**: Mix of Scoped and Transient services

## Key Patterns
- **CQRS**: Command Query Responsibility Segregation
- **Repository Pattern**: Data access abstraction
- **Service Layer**: Business logic separation
- **Dependency Injection**: Loose coupling

# Service Layer - Generic Repository Integration

This folder contains the service layer implementations that now fully utilize the generic repository pattern.

## Updated Services

All services have been updated to expose the full range of generic repository capabilities:

### 1. StudentService
- **Interface**: `IStudentService`
- **Implementation**: `StudentService`
- **Repository**: `IStudentRepo` → `Repository<Student>`

### 2. DepartmentService
- **Interface**: `IDepatrmentService`
- **Implementation**: `DepatrmentService`
- **Repository**: `IDepatrmentRepo` → `Repository<Depatrment>`

### 3. SubjectService
- **Interface**: `ISubjectService`
- **Implementation**: `SubjectService`
- **Repository**: `ISubjectRepo` → `Repository<Subject>`

### 4. StudentSubjectService
- **Interface**: `IStudentSubjectService`
- **Implementation**: `StudentSubjectService`
- **Repository**: `IStudentSubjectRepo` → `Repository<StudentSubject>`

### 5. DepartmentSubjectService
- **Interface**: `IDepartmentSubjectService`
- **Implementation**: `DepartmentSubjectService`
- **Repository**: `IDepartmentSubjectRepo` → `Repository<DepartmentSubject>`

## Available Methods

Each service now provides the following comprehensive set of operations:

### Basic CRUD Operations
- `GetByIdAsync(int id)` - Get entity by ID
- `GetAllAsync()` - Get all entities
- `AddAsync(T entity)` - Add single entity (returns the added entity)
- `AddRangeAsync(ICollection<T> entities)` - Add multiple entities
- `UpdateAsync(T entity)` - Update single entity
- `UpdateRangeAsync(ICollection<T> entities)` - Update multiple entities
- `DeleteAsync(T entity)` - Delete entity by reference
- `DeleteAsync(int id)` - Delete entity by ID
- `DeleteRangeAsync(ICollection<T> entities)` - Delete multiple entities

### Query Operations
- `FindAsync(Expression<Func<T, bool>> predicate)` - Find entities by predicate
- `FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)` - Get first entity matching predicate
- `ExistsAsync(Expression<Func<T, bool>> predicate)` - Check if entity exists
- `CountAsync(Expression<Func<T, bool>> predicate = null)` - Count entities

### Queryable Operations
- `GetTableNoTracking()` - Get queryable without change tracking (for read-only operations)
- `GetTableAsTracking()` - Get queryable with change tracking (for operations that modify entities)

### Transaction Operations
- `BeginTransaction()` - Start database transaction
- `Commit()` - Commit current transaction
- `RollBack()` - Rollback current transaction

### Save Changes
- `SaveChangesAsync()` - Save all pending changes

## Usage Examples

### Basic CRUD Operations
```csharp
// Get student by ID
var student = await _studentService.GetByIdAsync(1);

// Add new student
var newStudent = new Student { name = "John Doe", age = 20, department_id = 1 };
var addedStudent = await _studentService.AddAsync(newStudent);

// Update student
student.age = 21;
await _studentService.UpdateAsync(student);

// Delete student
await _studentService.DeleteAsync(1);
```

### Bulk Operations
```csharp
// Add multiple students
var students = new List<Student> 
{ 
    new Student { name = "Alice", age = 19, department_id = 1 },
    new Student { name = "Bob", age = 20, department_id = 1 }
};
await _studentService.AddRangeAsync(students);

// Update multiple students
var studentsToUpdate = students.Where(s => s.age < 20).ToList();
foreach (var student in studentsToUpdate)
{
    student.age = 20;
}
await _studentService.UpdateRangeAsync(studentsToUpdate);
```

### Advanced Queries
```csharp
// Find students by age
var youngStudents = await _studentService.FindAsync(s => s.age < 20);

// Check if student exists
var exists = await _studentService.ExistsAsync(s => s.name == "John Doe");

// Count students in department
var count = await _studentService.CountAsync(s => s.department_id == 1);

// Get queryable for complex queries
var query = _studentService.GetTableNoTracking()
    .Where(s => s.age > 18)
    .OrderBy(s => s.name)
    .Select(s => new { s.name, s.age });
```

### Transaction Management
```csharp
using (var transaction = _studentService.BeginTransaction())
{
    try
    {
        // Add student
        var student = await _studentService.AddAsync(newStudent);
        
        // Update department count
        var department = await _departmentService.GetByIdAsync(1);
        department.studentCount++;
        await _departmentService.UpdateAsync(department);
        
        // Commit transaction
        transaction.Commit();
    }
    catch
    {
        // Rollback on error
        transaction.Rollback();
        throw;
    }
}
```

## Benefits

1. **Consistent API**: All services now provide the same comprehensive set of operations
2. **Performance**: Bulk operations and transaction support for better performance
3. **Flexibility**: Queryable operations for complex queries and change tracking control
4. **Maintainability**: Services delegate to repositories, keeping business logic clean
5. **Type Safety**: Full type safety throughout the service layer
6. **Transaction Support**: Built-in transaction management for complex operations

## Service Registration

All services are registered in the DI container and can be injected into controllers or other services:

```csharp
// In Program.cs or Startup.cs
services.AddScoped<IStudentService, StudentService>();
services.AddScoped<IDepatrmentService, DepatrmentService>();
services.AddScoped<ISubjectService, SubjectService>();
services.AddScoped<IStudentSubjectService, StudentSubjectService>();
services.AddScoped<IDepartmentSubjectService, DepartmentSubjectService>();
```

## Next Steps

With the generic repository pattern fully implemented in the service layer, you can now:

1. **Enhance Controllers**: Use the new service methods in your API controllers
2. **Add Business Logic**: Implement complex business operations using the comprehensive service methods
3. **Performance Optimization**: Use bulk operations and transactions for better performance
4. **Advanced Queries**: Leverage queryable operations for complex data retrieval
5. **Error Handling**: Implement proper error handling using transaction rollback capabilities

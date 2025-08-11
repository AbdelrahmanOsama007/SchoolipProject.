# Infrastructure Bases - Generic Repository Pattern

This folder contains the base implementations for the generic repository pattern used throughout the application.

## Files

### IRepository.cs
Generic interface that defines comprehensive CRUD operations for all entities:

#### Basic CRUD Operations
- `GetByIdAsync(int id)` - Get entity by ID
- `GetAllAsync()` - Get all entities
- `AddAsync(T entity)` - Add single entity
- `AddRangeAsync(ICollection<T> entities)` - Add multiple entities
- `UpdateAsync(T entity)` - Update single entity
- `UpdateRangeAsync(ICollection<T> entities)` - Update multiple entities
- `DeleteAsync(T entity)` - Delete entity by reference
- `DeleteAsync(int id)` - Delete entity by ID
- `DeleteRangeAsync(ICollection<T> entities)` - Delete multiple entities

#### Query Operations
- `FindAsync(Expression<Func<T, bool>> predicate)` - Find entities by predicate
- `FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)` - Get first entity matching predicate
- `ExistsAsync(Expression<Func<T, bool>> predicate)` - Check if entity exists
- `CountAsync(Expression<Func<T, bool>> predicate = null)` - Count entities

#### Queryable Operations
- `GetTableNoTracking()` - Get queryable without change tracking
- `GetTableAsTracking()` - Get queryable with change tracking

#### Transaction Operations
- `BeginTransaction()` - Start database transaction
- `Commit()` - Commit current transaction
- `RollBack()` - Rollback current transaction

#### Save Changes
- `SaveChangesAsync()` - Save all pending changes

### Repository.cs
Generic base class that implements IRepository<T> and provides:
- All CRUD operations using Entity Framework
- Virtual methods that can be overridden by specific repositories
- DbContext and DbSet management
- Async operations throughout
- Transaction management
- Bulk operations support
- Change tracking control

## Usage

All specific repositories now inherit from `Repository<T>` and implement their respective interfaces:

```csharp
public class StudentRepo : Repository<Student>, IStudentRepo
{
    public StudentRepo(DbContext1 context) : base(context)
    {
    }

    // Override methods when custom logic is needed
    public override async Task<Student> GetByIdAsync(int id)
    {
        return await _context.Students
            .Include(s => s.department)
            .FirstOrDefaultAsync(s => s.id == id);
    }
}
```

## Advanced Usage Examples

### Bulk Operations
```csharp
// Add multiple students at once
var students = new List<Student> { student1, student2, student3 };
await _studentRepo.AddRangeAsync(students);

// Update multiple students
await _studentRepo.UpdateRangeAsync(studentsToUpdate);

// Delete multiple students
await _studentRepo.DeleteRangeAsync(studentsToDelete);
```

### Transaction Management
```csharp
using (var transaction = _studentRepo.BeginTransaction())
{
    try
    {
        await _studentRepo.AddAsync(newStudent);
        await _departmentRepo.UpdateAsync(department);
        
        transaction.Commit();
    }
    catch
    {
        transaction.Rollback();
        throw;
    }
}
```

### Queryable Operations
```csharp
// Get queryable without change tracking (for read-only operations)
var query = _studentRepo.GetTableNoTracking()
    .Where(s => s.age > 18)
    .OrderBy(s => s.name);

// Get queryable with change tracking (for operations that modify entities)
var trackingQuery = _studentRepo.GetTableAsTracking()
    .Where(s => s.department_id == 1);
```

## Benefits

1. **Code Reuse**: Common CRUD operations are implemented once
2. **Consistency**: All repositories follow the same pattern
3. **Maintainability**: Changes to base functionality affect all repositories
4. **Flexibility**: Specific repositories can override methods when needed
5. **Type Safety**: Generic implementation ensures type safety
6. **Performance**: Bulk operations and transaction support
7. **Flexibility**: Change tracking control for different scenarios

## Current Implementations

- StudentRepo : Repository<Student>, IStudentRepo
- DepatrmentRepo : Repository<Depatrment>, IDepatrmentRepo
- SubjectRepo : Repository<Subject>, ISubjectRepo
- StudentSubjectRepo : Repository<StudentSubject>, IStudentSubjectRepo
- DepartmentSubjectRepo : Repository<DepartmentSubject>, IDepartmentSubjectRepo

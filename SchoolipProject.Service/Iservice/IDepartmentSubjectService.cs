using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IDepartmentSubjectService
    {
        // Basic CRUD operations
        Task<DepartmentSubject> GetByIdAsync(int id);
        Task<IEnumerable<DepartmentSubject>> GetAllAsync();
        Task<DepartmentSubject> AddAsync(DepartmentSubject departmentSubject);
        Task AddRangeAsync(ICollection<DepartmentSubject> departmentSubjects);
        Task UpdateAsync(DepartmentSubject departmentSubject);
        Task UpdateRangeAsync(ICollection<DepartmentSubject> departmentSubjects);
        Task DeleteAsync(DepartmentSubject departmentSubject);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<DepartmentSubject> departmentSubjects);
        
        // Query operations
        Task<IEnumerable<DepartmentSubject>> FindAsync(System.Linq.Expressions.Expression<System.Func<DepartmentSubject, bool>> predicate);
        Task<DepartmentSubject> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<DepartmentSubject, bool>> predicate);
        Task<bool> ExistsAsync(System.Linq.Expressions.Expression<System.Func<DepartmentSubject, bool>> predicate);
        Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<DepartmentSubject, bool>> predicate = null);
        
        // Queryable operations
        System.Linq.IQueryable<DepartmentSubject> GetTableNoTracking();
        System.Linq.IQueryable<DepartmentSubject> GetTableAsTracking();
        
        // Transaction operations
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

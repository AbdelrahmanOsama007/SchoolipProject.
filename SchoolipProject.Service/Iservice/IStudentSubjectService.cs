using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IStudentSubjectService
    {
        // Basic CRUD operations
        Task<StudentSubject> GetByIdAsync(int id);
        Task<IEnumerable<StudentSubject>> GetAllAsync();
        Task<StudentSubject> AddAsync(StudentSubject studentSubject);
        Task AddRangeAsync(ICollection<StudentSubject> studentSubjects);
        Task UpdateAsync(StudentSubject studentSubject);
        Task UpdateRangeAsync(ICollection<StudentSubject> studentSubjects);
        Task DeleteAsync(StudentSubject studentSubject);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<StudentSubject> studentSubjects);
        
        // Query operations
        Task<IEnumerable<StudentSubject>> FindAsync(System.Linq.Expressions.Expression<System.Func<StudentSubject, bool>> predicate);
        Task<StudentSubject> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<StudentSubject, bool>> predicate);
        Task<bool> ExistsAsync(System.Linq.Expressions.Expression<System.Func<StudentSubject, bool>> predicate);
        Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<StudentSubject, bool>> predicate = null);
        
        // Queryable operations
        System.Linq.IQueryable<StudentSubject> GetTableNoTracking();
        System.Linq.IQueryable<StudentSubject> GetTableAsTracking();
        
        // Transaction operations
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

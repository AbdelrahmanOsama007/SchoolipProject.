using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IStudentService
    {
        // Basic CRUD operations
        Task<Student> GetByIdAsync(int id);
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> AddAsync(Student student);
        Task AddRangeAsync(ICollection<Student> students);
        Task UpdateAsync(Student student);
        Task UpdateRangeAsync(ICollection<Student> students);
        Task DeleteAsync(Student student);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<Student> students);
        
        // Query operations
        Task<IEnumerable<Student>> FindAsync(System.Linq.Expressions.Expression<System.Func<Student, bool>> predicate);
        Task<Student> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<Student, bool>> predicate);
        Task<bool> ExistsAsync(System.Linq.Expressions.Expression<System.Func<Student, bool>> predicate);
        Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<Student, bool>> predicate = null);
        
        // Queryable operations
        System.Linq.IQueryable<Student> GetTableNoTracking();
        System.Linq.IQueryable<Student> GetTableAsTracking();
        
        // Transaction operations
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

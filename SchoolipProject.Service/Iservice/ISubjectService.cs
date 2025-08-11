using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface ISubjectService
    {
        // Basic CRUD operations
        Task<Subject> GetByIdAsync(int id);
        Task<IEnumerable<Subject>> GetAllAsync();
        Task<Subject> AddAsync(Subject subject);
        Task AddRangeAsync(ICollection<Subject> subjects);
        Task UpdateAsync(Subject subject);
        Task UpdateRangeAsync(ICollection<Subject> subjects);
        Task DeleteAsync(Subject subject);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<Subject> subjects);
        
        // Query operations
        Task<IEnumerable<Subject>> FindAsync(System.Linq.Expressions.Expression<System.Func<Subject, bool>> predicate);
        Task<Subject> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<Subject, bool>> predicate);
        Task<bool> ExistsAsync(System.Linq.Expressions.Expression<System.Func<Subject, bool>> predicate);
        Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<Subject, bool>> predicate = null);
        
        // Queryable operations
        System.Linq.IQueryable<Subject> GetTableNoTracking();
        System.Linq.IQueryable<Subject> GetTableAsTracking();
        
        // Transaction operations
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IDepatrmentService
    {
        // Basic CRUD operations
        Task<Depatrment> GetByIdAsync(int id);
        Task<IEnumerable<Depatrment>> GetAllAsync();
        Task<Depatrment> AddAsync(Depatrment depatrment);
        Task AddRangeAsync(ICollection<Depatrment> depatrments);
        Task UpdateAsync(Depatrment depatrment);
        Task UpdateRangeAsync(ICollection<Depatrment> depatrments);
        Task DeleteAsync(Depatrment depatrment);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<Depatrment> depatrments);
        
        // Query operations
        Task<IEnumerable<Depatrment>> FindAsync(System.Linq.Expressions.Expression<System.Func<Depatrment, bool>> predicate);
        Task<Depatrment> FirstOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<Depatrment, bool>> predicate);
        Task<bool> ExistsAsync(System.Linq.Expressions.Expression<System.Func<Depatrment, bool>> predicate);
        Task<int> CountAsync(System.Linq.Expressions.Expression<System.Func<Depatrment, bool>> predicate = null);
        
        // Queryable operations
        System.Linq.IQueryable<Depatrment> GetTableNoTracking();
        System.Linq.IQueryable<Depatrment> GetTableAsTracking();
        
        // Transaction operations
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

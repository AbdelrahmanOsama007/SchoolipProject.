using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace SchoolipProject.Infrastructure.InfrastructureBases
{
    public interface IRepository<T> where T : class
    {
        // Basic CRUD operations
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(ICollection<T> entities);
        
        // Query operations
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        
        // Queryable operations
        IQueryable<T> GetTableNoTracking();
        IQueryable<T> GetTableAsTracking();
        
        // Transaction operations
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        
        // Save changes
        Task SaveChangesAsync();
    }
}

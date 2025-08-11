using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class DepatrmentService : IDepatrmentService
    {
        private readonly IDepatrmentRepo _repo;
        
        public DepatrmentService(IDepatrmentRepo repo)
        {
            _repo = repo;
        }

        // Basic CRUD operations
        public Task<Depatrment> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<Depatrment>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Depatrment> AddAsync(Depatrment depatrment) => _repo.AddAsync(depatrment);
        public Task AddRangeAsync(ICollection<Depatrment> depatrments) => _repo.AddRangeAsync(depatrments);
        public Task UpdateAsync(Depatrment depatrment) => _repo.UpdateAsync(depatrment);
        public Task UpdateRangeAsync(ICollection<Depatrment> depatrments) => _repo.UpdateRangeAsync(depatrments);
        public Task DeleteAsync(Depatrment depatrment) => _repo.DeleteAsync(depatrment);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task DeleteRangeAsync(ICollection<Depatrment> depatrments) => _repo.DeleteRangeAsync(depatrments);
        
        // Query operations
        public Task<IEnumerable<Depatrment>> FindAsync(Expression<Func<Depatrment, bool>> predicate) => _repo.FindAsync(predicate);
        public Task<Depatrment> FirstOrDefaultAsync(Expression<Func<Depatrment, bool>> predicate) => _repo.FirstOrDefaultAsync(predicate);
        public Task<bool> ExistsAsync(Expression<Func<Depatrment, bool>> predicate) => _repo.ExistsAsync(predicate);
        public Task<int> CountAsync(Expression<Func<Depatrment, bool>> predicate = null) => _repo.CountAsync(predicate);
        
        // Queryable operations
        public IQueryable<Depatrment> GetTableNoTracking() => _repo.GetTableNoTracking();
        public IQueryable<Depatrment> GetTableAsTracking() => _repo.GetTableAsTracking();
        
        // Transaction operations
        public IDbContextTransaction BeginTransaction() => _repo.BeginTransaction();
        public void Commit() => _repo.Commit();
        public void RollBack() => _repo.RollBack();
        
        // Save changes
        public Task SaveChangesAsync() => _repo.SaveChangesAsync();
    }
}

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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepo _repo;
        
        public SubjectService(ISubjectRepo repo)
        {
            _repo = repo;
        }

        // Basic CRUD operations
        public Task<Subject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<Subject>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Subject> AddAsync(Subject subject) => _repo.AddAsync(subject);
        public Task AddRangeAsync(ICollection<Subject> subjects) => _repo.AddRangeAsync(subjects);
        public Task UpdateAsync(Subject subject) => _repo.UpdateAsync(subject);
        public Task UpdateRangeAsync(ICollection<Subject> subjects) => _repo.UpdateRangeAsync(subjects);
        public Task DeleteAsync(Subject subject) => _repo.DeleteAsync(subject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task DeleteRangeAsync(ICollection<Subject> subjects) => _repo.DeleteRangeAsync(subjects);
        
        // Query operations
        public Task<IEnumerable<Subject>> FindAsync(Expression<Func<Subject, bool>> predicate) => _repo.FindAsync(predicate);
        public Task<Subject> FirstOrDefaultAsync(Expression<Func<Subject, bool>> predicate) => _repo.FirstOrDefaultAsync(predicate);
        public Task<bool> ExistsAsync(Expression<Func<Subject, bool>> predicate) => _repo.ExistsAsync(predicate);
        public Task<int> CountAsync(Expression<Func<Subject, bool>> predicate = null) => _repo.CountAsync(predicate);
        
        // Queryable operations
        public IQueryable<Subject> GetTableNoTracking() => _repo.GetTableNoTracking();
        public IQueryable<Subject> GetTableAsTracking() => _repo.GetTableAsTracking();
        
        // Transaction operations
        public IDbContextTransaction BeginTransaction() => _repo.BeginTransaction();
        public void Commit() => _repo.Commit();
        public void RollBack() => _repo.RollBack();
        
        // Save changes
        public Task SaveChangesAsync() => _repo.SaveChangesAsync();
    }
}

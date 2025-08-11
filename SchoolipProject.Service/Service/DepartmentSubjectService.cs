using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.InfrastructureBases;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class DepartmentSubjectService : IDepartmentSubjectService
    {
        private readonly IRepository<DepartmentSubject> _repo;
        
        public DepartmentSubjectService(IRepository<DepartmentSubject>   repo)
        {
            _repo = repo;
        }

        // Basic CRUD operations
        public Task<DepartmentSubject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<DepartmentSubject>> GetAllAsync() => _repo.GetAllAsync();
        public Task<DepartmentSubject> AddAsync(DepartmentSubject departmentSubject) => _repo.AddAsync(departmentSubject);
        public Task AddRangeAsync(ICollection<DepartmentSubject> departmentSubjects) => _repo.AddRangeAsync(departmentSubjects);
        public Task UpdateAsync(DepartmentSubject departmentSubject) => _repo.UpdateAsync(departmentSubject);
        public Task UpdateRangeAsync(ICollection<DepartmentSubject> departmentSubjects) => _repo.UpdateRangeAsync(departmentSubjects);
        public Task DeleteAsync(DepartmentSubject departmentSubject) => _repo.DeleteAsync(departmentSubject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task DeleteRangeAsync(ICollection<DepartmentSubject> departmentSubjects) => _repo.DeleteRangeAsync(departmentSubjects);
        
        // Query operations
        public Task<IEnumerable<DepartmentSubject>> FindAsync(Expression<Func<DepartmentSubject, bool>> predicate) => _repo.FindAsync(predicate);
        public Task<DepartmentSubject> FirstOrDefaultAsync(Expression<Func<DepartmentSubject, bool>> predicate) => _repo.FirstOrDefaultAsync(predicate);
        public Task<bool> ExistsAsync(Expression<Func<DepartmentSubject, bool>> predicate) => _repo.ExistsAsync(predicate);
        public Task<int> CountAsync(Expression<Func<DepartmentSubject, bool>> predicate = null) => _repo.CountAsync(predicate);
        
        // Queryable operations
        public IQueryable<DepartmentSubject> GetTableNoTracking() => _repo.GetTableNoTracking();
        public IQueryable<DepartmentSubject> GetTableAsTracking() => _repo.GetTableAsTracking();
        
        // Transaction operations
        public IDbContextTransaction BeginTransaction() => _repo.BeginTransaction();
        public void Commit() => _repo.Commit();
        public void RollBack() => _repo.RollBack();
        
        // Save changes
        public Task SaveChangesAsync() => _repo.SaveChangesAsync();
    }
}

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
    public class StudentSubjectService : IStudentSubjectService
    {
        private readonly IStudentSubjectRepo _repo;
        
        public StudentSubjectService(IStudentSubjectRepo repo)
        {
            _repo = repo;
        }

        // Basic CRUD operations
        public Task<StudentSubject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<StudentSubject>> GetAllAsync() => _repo.GetAllAsync();
        public Task<StudentSubject> AddAsync(StudentSubject studentSubject) => _repo.AddAsync(studentSubject);
        public Task AddRangeAsync(ICollection<StudentSubject> studentSubjects) => _repo.AddRangeAsync(studentSubjects);
        public Task UpdateAsync(StudentSubject studentSubject) => _repo.UpdateAsync(studentSubject);
        public Task UpdateRangeAsync(ICollection<StudentSubject> studentSubjects) => _repo.UpdateRangeAsync(studentSubjects);
        public Task DeleteAsync(StudentSubject studentSubject) => _repo.DeleteAsync(studentSubject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task DeleteRangeAsync(ICollection<StudentSubject> studentSubjects) => _repo.DeleteRangeAsync(studentSubjects);
        
        // Query operations
        public Task<IEnumerable<StudentSubject>> FindAsync(Expression<Func<StudentSubject, bool>> predicate) => _repo.FindAsync(predicate);
        public Task<StudentSubject> FirstOrDefaultAsync(Expression<Func<StudentSubject, bool>> predicate) => _repo.FirstOrDefaultAsync(predicate);
        public Task<bool> ExistsAsync(Expression<Func<StudentSubject, bool>> predicate) => _repo.ExistsAsync(predicate);
        public Task<int> CountAsync(Expression<Func<StudentSubject, bool>> predicate = null) => _repo.CountAsync(predicate);
        
        // Queryable operations
        public IQueryable<StudentSubject> GetTableNoTracking() => _repo.GetTableNoTracking();
        public IQueryable<StudentSubject> GetTableAsTracking() => _repo.GetTableAsTracking();
        
        // Transaction operations
        public IDbContextTransaction BeginTransaction() => _repo.BeginTransaction();
        public void Commit() => _repo.Commit();
        public void RollBack() => _repo.RollBack();
        
        // Save changes
        public Task SaveChangesAsync() => _repo.SaveChangesAsync();
    }
}

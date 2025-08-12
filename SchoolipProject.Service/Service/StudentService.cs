using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _repo;
        
        public StudentService(IStudentRepo repo)
        {
            _repo = repo;
        }

        // Basic CRUD operations
        public Task<Student> GetByIdAsync(int id) => _repo.GetTableNoTracking().Include(id => id.department).FirstOrDefaultAsync(s => s.id == id);
        public Task<IEnumerable<Student>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Student> AddAsync(Student student)
        {
            var studentresult = _repo.GetTableNoTracking().Where(x => x.name.Equals(student.name) && x.department_id == student.department_id).FirstOrDefault();
            if (studentresult != null) {
                return Task.FromResult<Student>(null);
            }
            {
              return _repo.AddAsync(student);
            }
            }
        public Task AddRangeAsync(ICollection<Student> students) => _repo.AddRangeAsync(students);
        public Task UpdateAsync(Student student) => _repo.UpdateAsync(student);
        public Task UpdateRangeAsync(ICollection<Student> students) => _repo.UpdateRangeAsync(students);
        public Task DeleteAsync(Student student) => _repo.DeleteAsync(student);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task DeleteRangeAsync(ICollection<Student> students) => _repo.DeleteRangeAsync(students);
        
        // Query operations
        public Task<IEnumerable<Student>> FindAsync(Expression<Func<Student, bool>> predicate) => _repo.FindAsync(predicate);
        public Task<Student> FirstOrDefaultAsync(Expression<Func<Student, bool>> predicate) => _repo.FirstOrDefaultAsync(predicate);
        public Task<bool> ExistsAsync(Expression<Func<Student, bool>> predicate) => _repo.ExistsAsync(predicate);
        public Task<int> CountAsync(Expression<Func<Student, bool>> predicate = null) => _repo.CountAsync(predicate);
        
        // Queryable operations
        public IQueryable<Student> GetTableNoTracking() => _repo.GetTableNoTracking();
        public IQueryable<Student> GetTableAsTracking() => _repo.GetTableAsTracking();
        
        // Transaction operations
        public IDbContextTransaction BeginTransaction() => _repo.BeginTransaction();
        public void Commit() => _repo.Commit();
        public void RollBack() => _repo.RollBack();
        
        // Save changes
        public Task SaveChangesAsync() => _repo.SaveChangesAsync();
    }
}

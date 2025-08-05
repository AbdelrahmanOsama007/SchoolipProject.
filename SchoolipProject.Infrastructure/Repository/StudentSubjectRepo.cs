using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;

namespace SchoolipProject.Infrastructure.Repository
{
    public class StudentSubjectRepo : IStudentSubjectRepo
    {
        private readonly DbContext1 _context;
        public StudentSubjectRepo(DbContext1 context)
        {
            _context = context;
        }

        public async Task<StudentSubject> GetByIdAsync(int id)
        {
            return await _context.StudentSubjects.FindAsync(id);
        }

        public async Task<IEnumerable<StudentSubject>> GetAllAsync()
        {
            return await _context.StudentSubjects.ToListAsync();
        }

        public async Task AddAsync(StudentSubject studentSubject)
        {
            await _context.StudentSubjects.AddAsync(studentSubject);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(StudentSubject studentSubject)
        {
            _context.StudentSubjects.Update(studentSubject);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.StudentSubjects.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

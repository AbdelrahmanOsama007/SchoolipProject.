using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Repository
{
    public class StudentSubjectRepo : Repository<StudentSubject>, IStudentSubjectRepo
    {
        public StudentSubjectRepo(DbContext1 context) : base(context)
        {
        }

        // Override methods when custom logic is needed
        public override async Task<StudentSubject> GetByIdAsync(int id)
        {
            return await _context.StudentSubjects.FindAsync(id);
        }

        public override async Task<IEnumerable<StudentSubject>> GetAllAsync()
        {
            return await _context.StudentSubjects.ToListAsync();
        }
    }
}

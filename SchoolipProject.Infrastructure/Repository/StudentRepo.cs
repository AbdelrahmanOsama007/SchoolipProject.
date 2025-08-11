using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Repository
{
    public class StudentRepo : Repository<Student>, IStudentRepo
    {
        public StudentRepo(DbContext1 context) : base(context)
        {
        }


        // Override methods when custom logic is needed (e.g., Include statements)
        public override async Task<Student> GetByIdAsync(int id)
        {
            return await _context.Students
                .Include(s => s.department)
                .FirstOrDefaultAsync(s => s.id == id);
        }

        public override async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students
                .Include(s => s.department)
                .ToListAsync();
        }

    }
}
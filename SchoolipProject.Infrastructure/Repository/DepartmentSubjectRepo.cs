using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Repository
{
    public class DepartmentSubjectRepo : Repository<DepartmentSubject>, IDepartmentSubjectRepo
    {
        public DepartmentSubjectRepo(DbContext1 context) : base(context)
        {
        }

        // Override methods when custom logic is needed
        public override async Task<DepartmentSubject> GetByIdAsync(int id)
        {
            return await _context.DepartmentSubjects.FindAsync(id);
        }

        public override async Task<IEnumerable<DepartmentSubject>> GetAllAsync()
        {
            return await _context.DepartmentSubjects.ToListAsync();
        }
    }
}

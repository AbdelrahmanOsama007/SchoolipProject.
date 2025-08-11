using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Repository
{
    public class SubjectRepo : Repository<Subject>, ISubjectRepo
    {
        public SubjectRepo(DbContext1 context) : base(context)
        {
        }

        // Override methods when custom logic is needed
        public override async Task<Subject> GetByIdAsync(int id)
        {
            return await _context.subjects.FindAsync(id);
        }

        public override async Task<IEnumerable<Subject>> GetAllAsync()
        {
            return await _context.subjects.ToListAsync();
        }
    }
}

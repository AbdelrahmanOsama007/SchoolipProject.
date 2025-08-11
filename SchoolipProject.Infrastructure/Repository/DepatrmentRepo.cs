using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Repository
{
    public class DepatrmentRepo : Repository<Depatrment>, IDepatrmentRepo
    {
        public DepatrmentRepo(DbContext1 context) : base(context)
        {
        }

        // Override methods when custom logic is needed
        public override async Task<Depatrment> GetByIdAsync(int id)
        {
            return await _context.Depatrment.FindAsync(id);
        }

        public override async Task<IEnumerable<Depatrment>> GetAllAsync()
        {
            return await _context.Depatrment.ToListAsync();
        }
    }
}

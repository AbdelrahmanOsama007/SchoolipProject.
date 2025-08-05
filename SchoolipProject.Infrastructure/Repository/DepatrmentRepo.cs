using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;

namespace SchoolipProject.Infrastructure.Repository
{
    public class DepatrmentRepo : IDepatrmentRepo
    {
        private readonly DbContext1 _context;
        public DepatrmentRepo(DbContext1 context)
        {
            _context = context;
        }

        public async Task<Depatrment> GetByIdAsync(int id)
        {
            return await _context.Depatrations.FindAsync(id);
        }

        public async Task<IEnumerable<Depatrment>> GetAllAsync()
        {
            return await _context.Depatrations.ToListAsync();
        }

        public async Task AddAsync(Depatrment depatrment)
        {
            await _context.Depatrations.AddAsync(depatrment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Depatrment depatrment)
        {
            _context.Depatrations.Update(depatrment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Depatrations.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

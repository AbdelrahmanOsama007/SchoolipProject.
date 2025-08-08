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
            return await _context.Depatrment.FindAsync(id);
        }

        public async Task<IEnumerable<Depatrment>> GetAllAsync()
        {
            return await _context.Depatrment.ToListAsync();
        }

        public async Task AddAsync(Depatrment depatrment)
        {
            await _context.Depatrment.AddAsync(depatrment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Depatrment depatrment)
        {
            _context.Depatrment.Update(depatrment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Depatrment.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

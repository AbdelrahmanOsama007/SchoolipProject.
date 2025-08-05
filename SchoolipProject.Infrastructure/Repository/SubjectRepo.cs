using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;

namespace SchoolipProject.Infrastructure.Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly DbContext1 _context;
        public SubjectRepo(DbContext1 context)
        {
            _context = context;
        }

        public async Task<Subject> GetByIdAsync(int id)
        {
            return await _context.subjects.FindAsync(id);
        }

        public async Task<IEnumerable<Subject>> GetAllAsync()
        {
            return await _context.subjects.ToListAsync();
        }

        public async Task AddAsync(Subject subject)
        {
            await _context.subjects.AddAsync(subject);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Subject subject)
        {
            _context.subjects.Update(subject);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.subjects.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

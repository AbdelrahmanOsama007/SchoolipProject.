using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Data;
using SchoolipProject.Infrastructure.Irepository;

namespace SchoolipProject.Infrastructure.Repository
{
    public class DepartmentSubjectRepo : IDepartmentSubjectRepo
    {
        private readonly DbContext1 _context;
        public DepartmentSubjectRepo(DbContext1 context)
        {
            _context = context;
        }

        public async Task<DepartmentSubject> GetByIdAsync(int id)
        {
            return await _context.DepartmentSubjects.FindAsync(id);
        }

        public async Task<IEnumerable<DepartmentSubject>> GetAllAsync()
        {
            return await _context.DepartmentSubjects.ToListAsync();
        }

        public async Task AddAsync(DepartmentSubject departmentSubject)
        {
            await _context.DepartmentSubjects.AddAsync(departmentSubject);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DepartmentSubject departmentSubject)
        {
            _context.DepartmentSubjects.Update(departmentSubject);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.DepartmentSubjects.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

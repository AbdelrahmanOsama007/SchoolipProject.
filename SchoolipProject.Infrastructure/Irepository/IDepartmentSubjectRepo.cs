using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Infrastructure.Irepository
{
    public interface IDepartmentSubjectRepo
    {
        Task<DepartmentSubject> GetByIdAsync(int id);
        Task<IEnumerable<DepartmentSubject>> GetAllAsync();
        Task AddAsync(DepartmentSubject departmentSubject);
        Task UpdateAsync(DepartmentSubject departmentSubject);
        Task DeleteAsync(int id);
    }
}

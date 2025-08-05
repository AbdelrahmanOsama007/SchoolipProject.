using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IDepartmentSubjectService
    {
        Task<DepartmentSubject> GetByIdAsync(int id);
        Task<IEnumerable<DepartmentSubject>> GetAllAsync();
        Task AddAsync(DepartmentSubject departmentSubject);
        Task UpdateAsync(DepartmentSubject departmentSubject);
        Task DeleteAsync(int id);
    }
}

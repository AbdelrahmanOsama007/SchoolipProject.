using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IStudentSubjectService
    {
        Task<StudentSubject> GetByIdAsync(int id);
        Task<IEnumerable<StudentSubject>> GetAllAsync();
        Task AddAsync(StudentSubject studentSubject);
        Task UpdateAsync(StudentSubject studentSubject);
        Task DeleteAsync(int id);
    }
}

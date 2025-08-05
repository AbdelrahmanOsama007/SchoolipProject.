using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Infrastructure.Irepository
{
    public interface ISubjectRepo
    {
        Task<Subject> GetByIdAsync(int id);
        Task<IEnumerable<Subject>> GetAllAsync();
        Task AddAsync(Subject subject);
        Task UpdateAsync(Subject subject);
        Task DeleteAsync(int id);
    }
}

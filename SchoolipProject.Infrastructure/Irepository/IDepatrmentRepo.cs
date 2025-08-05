using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Infrastructure.Irepository
{
    public interface IDepatrmentRepo
    {
        Task<Depatrment> GetByIdAsync(int id);
        Task<IEnumerable<Depatrment>> GetAllAsync();
        Task AddAsync(Depatrment depatrment);
        Task UpdateAsync(Depatrment depatrment);
        Task DeleteAsync(int id);
    }
}

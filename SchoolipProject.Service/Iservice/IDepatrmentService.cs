using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Service.Iservice
{
    public interface IDepatrmentService
    {
        Task<Depatrment> GetByIdAsync(int id);
        Task<IEnumerable<Depatrment>> GetAllAsync();
        Task AddAsync(Depatrment depatrment);
        Task UpdateAsync(Depatrment depatrment);
        Task DeleteAsync(int id);
    }
}

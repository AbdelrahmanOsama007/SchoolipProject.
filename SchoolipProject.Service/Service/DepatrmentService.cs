using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class DepatrmentService : IDepatrmentService
    {
        private readonly IDepatrmentRepo _repo;
        public DepatrmentService(IDepatrmentRepo repo)
        {
            _repo = repo;
        }
        public Task<Depatrment> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<Depatrment>> GetAllAsync() => _repo.GetAllAsync();
        public Task AddAsync(Depatrment depatrment) => _repo.AddAsync(depatrment);
        public Task UpdateAsync(Depatrment depatrment) => _repo.UpdateAsync(depatrment);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}

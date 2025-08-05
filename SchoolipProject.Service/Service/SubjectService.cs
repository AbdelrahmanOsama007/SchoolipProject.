using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepo _repo;
        public SubjectService(ISubjectRepo repo)
        {
            _repo = repo;
        }
        public Task<Subject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<Subject>> GetAllAsync() => _repo.GetAllAsync();
        public Task AddAsync(Subject subject) => _repo.AddAsync(subject);
        public Task UpdateAsync(Subject subject) => _repo.UpdateAsync(subject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}

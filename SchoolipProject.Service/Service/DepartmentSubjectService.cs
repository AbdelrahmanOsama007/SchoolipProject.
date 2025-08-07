    using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class DepartmentSubjectService : IDepartmentSubjectService
    {
        private readonly IDepartmentSubjectRepo _repo;
        public DepartmentSubjectService(IDepartmentSubjectRepo repo)
        {
            _repo = repo;
        }
        public Task<DepartmentSubject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<DepartmentSubject>> GetAllAsync() => _repo.GetAllAsync();
        public Task AddAsync(DepartmentSubject departmentSubject) => _repo.AddAsync(departmentSubject);
        public Task UpdateAsync(DepartmentSubject departmentSubject) => _repo.UpdateAsync(departmentSubject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}

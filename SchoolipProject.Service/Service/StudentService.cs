using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _repo;
        public StudentService(IStudentRepo repo)
        {
            _repo = repo;
        }
        public Task<Student> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<Student>> GetAllAsync() => _repo.GetAllAsync();
        public Task AddAsync(Student student) => _repo.AddAsync(student);
        public Task UpdateAsync(Student student) => _repo.UpdateAsync(student);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}

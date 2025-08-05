using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.Irepository;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Service.Service
{
    public class StudentSubjectService : IStudentSubjectService
    {
        private readonly IStudentSubjectRepo _repo;
        public StudentSubjectService(IStudentSubjectRepo repo)
        {
            _repo = repo;
        }
        public Task<StudentSubject> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<IEnumerable<StudentSubject>> GetAllAsync() => _repo.GetAllAsync();
        public Task AddAsync(StudentSubject studentSubject) => _repo.AddAsync(studentSubject);
        public Task UpdateAsync(StudentSubject studentSubject) => _repo.UpdateAsync(studentSubject);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    }
}

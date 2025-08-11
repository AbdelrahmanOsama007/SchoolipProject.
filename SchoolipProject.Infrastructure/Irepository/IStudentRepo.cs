using SchoolipProject.Data.Entites;
using SchoolipProject.Infrastructure.InfrastructureBases;

namespace SchoolipProject.Infrastructure.Irepository
{
    public interface IStudentRepo : IRepository<Student>
    {
        // Add any student-specific methods here if needed
    }
}

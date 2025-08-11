using MediatR;
using SchoolipProject.Core.Bases;
using SchoolipProject.Core.Feauters.Student.Qeuries.Dto;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class GetStudentQuery : IRequest<Response<StudentDto>>
    {
        public int id { get; set; }
    }
}
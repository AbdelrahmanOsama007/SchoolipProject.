using MediatR;
using SchoolipProject.Core.Bases;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class DeleteStudentQuery : IRequest<Response<bool>>
    {
        public int id { get; set; }
        public DeleteStudentQuery(int id)
        {
            this.id = id;
        }
    }
}

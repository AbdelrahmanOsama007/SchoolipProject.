using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolipProject.Core.Bases;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class AddStudentQuery: IRequest<Response<bool>>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
    }
}

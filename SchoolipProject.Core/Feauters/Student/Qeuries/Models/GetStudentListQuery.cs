using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using MediatR;
using SchoolipProject.Core.Feauters.Student.Qeuries.Dto;
using SchoolipProject.Core.Bases;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<StudentDto>>>
    {

    }
}

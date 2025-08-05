using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolipProject.Data.Entites;
using MediatR;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class GetStudentListQuery : IRequest<List<SchoolipProject.Data.Entites.Student>>
    {


    }
}

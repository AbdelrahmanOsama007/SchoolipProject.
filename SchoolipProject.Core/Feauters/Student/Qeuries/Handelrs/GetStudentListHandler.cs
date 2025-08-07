using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolipProject.Data.Entites;
using SchoolipProject.Core.Feauters.Student.Qeuries.Models;
using SchoolipProject.Service.Service;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<SchoolipProject.Data.Entites.Student>>
    {
        readonly IStudentService _StuddentService;
        public GetStudentListHandler(IStudentService studentService  ) {
            _StuddentService = studentService;
        }

       
        Task<List<Data.Entites.Student>> IRequestHandler<GetStudentListQuery, List<Data.Entites.Student>>.Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var students = _StuddentService.GetAllAsync().Result;
                return Task.FromResult(students.ToList());
            }
            catch (Exception ex)
            {   
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving the student list.", ex);
            }

        }
    }
}

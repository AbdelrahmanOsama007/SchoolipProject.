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
using SchoolipProject.Core.Feauters.Student.Qeuries.Dto;
using AutoMapper;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDto>>
    {
        readonly IStudentService _StuddentService;
        readonly IMapper _imapper;
        public GetStudentListHandler(IStudentService studentService, IMapper imapper) {
            _StuddentService = studentService;
            this._imapper = imapper;
        }

       
        async Task<List<StudentDto>> IRequestHandler<GetStudentListQuery, List<StudentDto>>.Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var students = await _StuddentService.GetAllAsync();
                var StudentD = _imapper.Map<List<StudentDto>>(students);
                return StudentD;
            }
            catch (Exception ex)
            {   
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving the student list.", ex);
            }

        }
    }
}

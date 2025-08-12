using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using SchoolipProject.Core.Bases;
using SchoolipProject.Core.Feauters.Student.Qeuries.Models;
using SchoolipProject.Data.Entites;
using SchoolipProject.Service.Iservice;

namespace SchoolipProject.Core.Feauters.Student.Commands.Handlers
{
    public class AddStudentHandler : ResponseHandler, IRequestHandler<AddStudentQuery, Response<bool>>
    {
        readonly IStudentService studentService;
        readonly IMapper mapper;

        public AddStudentHandler(IStudentService _studentService, IMapper _mapper)
        {
            studentService = _studentService;
            mapper = _mapper;
        }

        public async Task<Response<bool>> Handle(AddStudentQuery request, CancellationToken cancellationToken)
        {   
            try
            {
                // Use AutoMapper to map from AddStudentQuery to Student entity
                var student = mapper.Map<SchoolipProject.Data.Entites.Student>(request);
                
                var result = await studentService.AddAsync(student);
                if (result != null)
                {
                    return Success<bool>(true, "Student added successfully.");
                }
                return BadRequest<bool>("Failed to add student. Student with same name in this department may already exist.");
            }
            catch (Exception ex)
            {
                return BadRequest<bool>($"An error occurred while adding student: {ex.Message}");
            }
        }
    }
}

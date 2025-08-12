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
    public class DeleteStudentHandler : ResponseHandler, IRequestHandler<DeleteStudentQuery, Response<bool>>
    {   
        readonly IStudentService _studentService;
        readonly IMapper _mapper;
        
        public DeleteStudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        
        public async Task<Response<bool>> Handle(DeleteStudentQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // Check if student exists
                var existingStudent = await _studentService.GetByIdAsync(request.id);
                if (existingStudent == null)
                {
                    return NotFound<bool>("Student not found.");
                }

                // Delete the student
                await _studentService.DeleteAsync(request.id);

                return Success<bool>(true, "Student deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest<bool>($"An error occurred while deleting student: {ex.Message}");
            }
        }
    }
}

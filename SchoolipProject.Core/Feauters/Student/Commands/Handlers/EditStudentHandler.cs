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
    public class EditStudentHandler : ResponseHandler, IRequestHandler<EditStudentQuery, Response<bool>>
    {   
        readonly IStudentService _studentService;
        readonly IMapper _mapper;
        
        public EditStudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        
        public async Task<Response<bool>> Handle(EditStudentQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // Check if student exists
                var existingStudent = await _studentService.GetByIdAsync(request.Id);
                if (existingStudent == null)
                {
                    return NotFound<bool>("Student not found.");
                }

                // Check if another student with same name exists in the same department
                var duplicateStudent = await _studentService.FirstOrDefaultAsync(s => 
                    s.name.Equals(request.Name) && 
                    s.department_id == request.DepartmentId && 
                    s.id != request.Id);
                
                if (duplicateStudent != null)
                {
                    return BadRequest<bool>("A student with the same name already exists in this department.");
                }

                // Update student properties directly on existing entity
                // Map the request values onto the existing entity
                _mapper.Map(request, existingStudent);

                // Save changes
                await _studentService.UpdateAsync(existingStudent);

                // Save changes
                await _studentService.UpdateAsync(existingStudent);

                return Success<bool>(true, "Student updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest<bool>($"An error occurred while updating student: {ex.Message}");
            }
        }
    }
}

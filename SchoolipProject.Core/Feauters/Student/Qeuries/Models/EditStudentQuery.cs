using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MediatR;
using SchoolipProject.Core.Bases;

namespace SchoolipProject.Core.Feauters.Student.Qeuries.Models
{
    public class EditStudentQuery : IRequest<Response<bool>>
    {
        [Required(ErrorMessage = "Student ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Student ID must be a positive number")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Student age is required")]
        [Range(5, 100, ErrorMessage = "Age must be between 5 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Department ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Department ID must be a positive number")]
        public int DepartmentId { get; set; }
    }
}

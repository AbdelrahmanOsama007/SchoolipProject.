using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolipProject.Core.Feauters.Student.Qeuries.Dto;

namespace SchoolipProject.Core.Feauters.Student.Commands.Validation
{
    public class AddStudentValidatior : AbstractValidator<StudentDto>
    {
        public AddStudentValidatior(string name, int age, int departmentId)
        {
            RuleFor(x => x.name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");
            RuleFor(x => x.age)
                .InclusiveBetween(1, 120).WithMessage("Age must be between 1 and 120.");
            RuleFor(x => x.departmentName)
                .NotEmpty().WithMessage("Department name is required.");
        }
    }
}

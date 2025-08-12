using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolipProject.Core.Feauters.Student.Commands.Models;
using SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs;
using SchoolipProject.Core.Feauters.Student.Qeuries.Models;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Core.Mapping.Students.QueryMapping
{
    public class Profiler : AutoMapper.Profile
    {
        public Profiler()
        {
            GetStudentListMapping();
            GetStudentQueryMapping();
            AddStudentQueryMapping();
            EditStudentQueryMapping();
        }

        public void GetStudentListMapping()
        {
            CreateMap<Student, SchoolipProject.Core.Feauters.Student.Qeuries.Dto.StudentDto>()
                .ForMember(dest => dest.departmentName, opt => opt.MapFrom(src => src.department.Name));
        }

        public void GetStudentQueryMapping()
        {
            CreateMap<Student, SchoolipProject.Core.Feauters.Student.Qeuries.Dto.StudentDto>()
                .ForMember(dest => dest.departmentName, opt => opt.MapFrom(src => src.department.Name));
        }

        public void AddStudentQueryMapping()
        {
            CreateMap<AddStudentQuery, Student>()
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.Age))
                .ForMember(dest => dest.department_id, opt => opt.MapFrom(src => src.DepartmentId));
        }

        public void EditStudentQueryMapping()
        {
            CreateMap<EditStudentQuery, Student>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id    ))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.Age))
                .ForMember(dest => dest.department_id, opt => opt.MapFrom(src => src.DepartmentId));
        }
    }
}

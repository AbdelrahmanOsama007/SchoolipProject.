using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs;

namespace SchoolipProject.Core.Mapping.Students.QueryMapping
{
    public partial class Prrofiler : AutoMapper.Profile
    {
        public void GetStudentListMapping()
        {
            CreateMap<SchoolipProject.Data.Entites.Student, SchoolipProject.Core.Feauters.Student.Qeuries.Dto.StudentDto>()
        .ForMember(dest => dest.departmentName, opt => opt.MapFrom(src => src.department.Name));

        }
    }
}

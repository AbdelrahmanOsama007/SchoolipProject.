using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolipProject.Core.Mapping
{
    public class Prrofiler: AutoMapper.Profile
    {
        public Prrofiler() { 
        CreateMap<SchoolipProject.Data.Entites.Student, SchoolipProject.Core.Feauters.Student.Qeuries.Dto.StudentDto>()
            .ForMember(dest => dest.departmentName, opt => opt.MapFrom(src => src.department.Name));

        }
    }
}

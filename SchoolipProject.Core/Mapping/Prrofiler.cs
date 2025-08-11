using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolipProject.Core.Mapping.Students.QueryMapping
{
    public partial class  Prrofiler: AutoMapper.Profile
    {
        public Prrofiler() {
            GetStudentListMapping();
            GetStudentQueryMapping();
        }
    }
}

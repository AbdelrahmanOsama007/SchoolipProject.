using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolipProject.Data.Entites
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }



    }
}

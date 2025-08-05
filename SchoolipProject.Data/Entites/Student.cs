using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolipProject.Data.Entites
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }  // Made name public
        public int age { get; set; }
        public int department_id { get; set; }
        
        [ForeignKey("department_id")]
        public virtual Depatrment department { get; set; }
        
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}

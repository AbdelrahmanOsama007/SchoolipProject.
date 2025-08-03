using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolipProject.Data.Entites
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        string name {  get; set; }
        public int age { get; set; }
        public int department_id { get; set; }
        [ForeignKey("department_id")]
        [InverseProperty("department")]
        public virtual Depatrment department { get; set; }


    }
}

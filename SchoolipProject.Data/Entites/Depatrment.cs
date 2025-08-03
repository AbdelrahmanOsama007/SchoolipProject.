
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolipProject.Data.Entites
{
    public class Depatrment
    {
        public string Name { get; set; }
        [Key]
        public int id { get; set; }
       
        public virtual  ICollection<Student> students { get; set; }


    }
}

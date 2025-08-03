using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolipProject.Data.Entites;

namespace SchoolipProject.Infrastructure.Data
{
    public class DbContext1 : DbContext
    {
        public DbContext1() { }
        public DbContext1(DbContextOptions<DbContext1>options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Depatrment> Depatrations { get; set; }
        public DbSet<Subject>subjects { get; set; } 


         
    }
}

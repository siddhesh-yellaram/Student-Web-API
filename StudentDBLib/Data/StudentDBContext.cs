using StudentDBLib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBLib.Data
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext() : base("studentDB") { }
        public DbSet<Student> StudentsSet { get; set; }
    }
}

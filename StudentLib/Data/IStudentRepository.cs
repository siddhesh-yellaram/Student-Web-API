using StudentDBLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Data
{
   public interface IStudentRepository
   {
        string AddStudent(StudentDTO s);
        void DeleteStudent(string Id);
        void EditStudent(string Id, StudentDTO s);
        List<Student> GetAllStudents();
        Student GetStudent(string Id);
    }
}

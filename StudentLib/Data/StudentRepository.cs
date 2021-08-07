using StudentDBLib.Data;
using StudentDBLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Data
{
    public class StudentRepository:IStudentRepository
    {
        private StudentDBContext _db;
        public StudentRepository()
        {
            _db = new StudentDBContext();
        }
        public List<Student> GetAllStudents()
        {
            return _db.StudentsSet.ToList<Student>();
        }
        public Student GetStudent(string Id)
        {
            return _db.StudentsSet.SingleOrDefault(x => x.Id == Id);
        }
        public string AddStudent(StudentDTO s)
        {
            var temp = new Student { Age = s.Age, Email = s.Email, Date = s.Date, IsMale = s.IsMale, Name = s.Name };
            _db.StudentsSet.Add(temp);
            _db.SaveChanges();
            return temp.Id;
        }
        public void EditStudent(string Id, StudentDTO s)
        {
            this.DeleteStudent(Id);
            var temp = new Student { Age = s.Age, Email = s.Email, Date = s.Date, IsMale = s.IsMale, Name = s.Name };
            temp.Id = Id;
            _db.StudentsSet.Add(temp);
            _db.SaveChanges();
        }
        public void DeleteStudent(string Id)
        {
            var temp = this.GetStudent(Id);
            _db.StudentsSet.Remove(temp);
            _db.SaveChanges();
        }
    }
}

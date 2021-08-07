using StudentDBLib.Model;
using StudentLib.Data;
using StudentLib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentWebAPI.Controllers
{
    [RoutePrefix("api/v1/students")]
    public class StudentController : ApiController
    {
        private IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Json(_service.GetAllStudents());
        }
       
        [Route("{studentId}")]
        public IHttpActionResult Get(string studentId)
        {
            return Json(_service.GetStudent(studentId));
        }

        [Route("")]
        public IHttpActionResult Post(StudentDTO temp)
        {
            return Json(_service.AddStudent(temp));
        }

        [Route("")]
        public void Put(StudentDTO temp)
        {
            var id = temp.Id;
            _service.EditStudent(id, temp);
        }

        [Route("{studentId}")]
        public void Delete(string studentId)
        {
            _service.DeleteStudent(studentId);
        }
    }
}

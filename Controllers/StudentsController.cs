using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace EmployeeService.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> lststudents = new List<Student>()
        {
            new Student { ID = 1, Name = "Tom" },
            new Student { ID = 2, Name = "Jerry" },
            new Student { ID = 3, Name = "Donald" }
        };

        public IHttpActionResult Get()
        {
            return Ok(lststudents);
        }

        public IHttpActionResult Get(int ID)
        {
            var result = lststudents.FirstOrDefault(x => x.ID == ID);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

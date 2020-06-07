using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> GetEmployees()
        {
            using (DevDBEntities entities = new DevDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}

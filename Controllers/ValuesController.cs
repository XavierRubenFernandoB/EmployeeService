using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    //[Authorize]
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //[Route(Name = "GetStudentById")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("{id}/GetMyValue")]
        public string GetValue(int id)
        {
            return "Get My Value";
        }

        [Route("~/api/GetMyValue2/{id:int:min(1)}")] //override the Route Prefix, specify routing constraints
        public string GetValue2(int id)
        {
            return "Get My Value 2";
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]int i) //NEED FOR generating links using route names
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Headers.Location = new Uri(Request.RequestUri + "/" + i.ToString());
            //response.Headers.Location = new Uri(Url.Link("GetStudentById", new { id = i } ));
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api_For_App.Controllers
{
    public class UserController : ApiController
    {
        Models.TestClass aclass = new Models.TestClass();
        List<Models.TestClass> _aclass = new List<Models.TestClass>();
        [HttpGet]
        [EnableCors("*", "*", "*")]
        //[Route("/api/values")]
        public List<Models.TestClass> Get()
        {

            aclass.a = "test: [{aa},{aa},{aa}]";
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            return _aclass;

        }

        // GET api/values/5
        public List<Models.TestClass> Get(int id)
        {
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            _aclass.Add(new Models.TestClass { a = "ab" });
            return _aclass;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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

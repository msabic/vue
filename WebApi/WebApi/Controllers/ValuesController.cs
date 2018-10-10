using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace WebApi.Controllers
{
    [AllowAnonymous]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            List<Models.Test> _t = new List<Models.Test>();
            Models.Test t = new Models.Test();
            t.test = "ab";
            _t.Add(t);
            _t.Add(t);
            _t.Add(t);
            _t.Add(t);

            return Ok(_t);
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

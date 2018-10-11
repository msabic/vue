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
       
        [HttpGet]
        [EnableCors("*", "*", "*")]
        //[Route("/api/values")]
        public IHttpActionResult Get()
        {
            List<Models.UserModel> _user = new List<Models.UserModel>();
            Models.UserModel user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            _user.Add(user);
            user = new Models.UserModel(1, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            _user.Add(user);
            return Ok(_user);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
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

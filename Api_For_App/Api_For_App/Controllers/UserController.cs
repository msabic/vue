using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Models.Model;
namespace Api_For_App.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();
        
        List<Models.UserModel> _user = new List<Models.UserModel>();
        [HttpGet]
        [EnableCors("*", "*", "*", "*")]
        //[Route("/api/values")]
        public IHttpActionResult Get()
        {
            List <Doctor> _doctor = _DB.GetDoctor();
            //Models.UserModel user = new Models.UserModel(1, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(2, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(3, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(4, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(5, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(6, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(7, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(8, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(9, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(10, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(11, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(12, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(13, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(14, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(15, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(16, "Mijo", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            //user = new Models.UserModel(17, "Mate", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", false, 1);
            //_user.Add(user);
            //user = new Models.UserModel(18, "Ante", "Šabić", "mijo.sabic@gmail.com", "saf", "012/345-678", true, 1);
            //_user.Add(user);
            return Ok(_doctor);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/values
        public void Post([FromBody]Doctor doctor)
        {
            _DB.AddDoctor(doctor);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Models.UserModel value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api_For_App.Controllers
{
    public class DoctorController : ApiController
    {
        DBCommunication.DBCommunicationAdmin _DB = new DBCommunication.DBCommunicationAdmin();

        List<Models.UserModel> _user = new List<Models.UserModel>();
        [HttpGet]
        [EnableCors("*", "*", "*", "*")]
        //[Route("/api/values")]
        public IHttpActionResult Get()
        {
            List<Doctor> _doctor = _DB.GetDoctor();
            return Ok(_doctor);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            Doctor doctor = _DB.GetDoctorForID(id);
            return Ok(doctor);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Doctor doctor)
        {
            //_DB.AddDoctor(doctor);
            if (_DB.AddDoctor(doctor)) { return Ok(true); } else { return Ok(false); }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Models.UserModel value)
        {

        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (_DB.DeleteDoctor(id)) { return Ok(true); } else { return Ok(false); }

        }
    }
}

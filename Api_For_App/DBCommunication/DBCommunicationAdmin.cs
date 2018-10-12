using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using DBCommunication.DBCommunicationGET;
using DBCommunication.DBCommunicationNEW;

namespace DBCommunication
{
    public class DBCommunicationAdmin : DBCommunication
    {
        public bool AddDoctor(Doctor doctor)
        {
            try
            {
                AddDoctor addDoctor = new AddDoctor();
                addDoctor.Execute(doctor);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

            }
        }

        public List<Doctor> GetDoctor()
        {
            try
            {
                GetDoctor doctor = new GetDoctor();
                return doctor.Execute();
            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }
    }
}

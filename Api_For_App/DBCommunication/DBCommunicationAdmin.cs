using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using DBCommunication.DBCommunicationGET;
using DBCommunication.DBCommunicationNEW;
using DBCommunication.DBCommunicationDELETE;

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

        public bool DeleteDoctor(int id)
        {
            try
            {
                DeleteDoctor addDoctor = new DeleteDoctor();
                addDoctor.Execute(id);
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

        public Doctor GetDoctorForID(int id)
        {
            try
            {
                GetDoctorForID doctor = new GetDoctorForID();
                return doctor.Execute(id);
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

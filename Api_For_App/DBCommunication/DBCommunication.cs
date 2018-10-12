using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public interface DBCommunication
    {
        List<Models.Model.Doctor> GetDoctor();
        bool AddDoctor(Doctor doctor);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication.DBCommunicationGET
{
    public class GetUser
    {
        MySql.Data.MySqlClient.MySqlConnection db = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString.ConnString.ToString());
        public void Get()
        {
            db.Open();
        }
    }
}

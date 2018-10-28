using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication.DBCommunicationDELETE
{
    class DeleteDoctor
    {

        public bool Execute(int id)
        {
            Models.Model.Doctor doctor = new Models.Model.Doctor();
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString.ConnString.ToString()))
                {
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand command = conn.CreateCommand();
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", id));
                    command.CommandText = string.Format(@"DELETE FROM  doktor where ID_Doktor=@id;");
                    try
                    {
                        MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}

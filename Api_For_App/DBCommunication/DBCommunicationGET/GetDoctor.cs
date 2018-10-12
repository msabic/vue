using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication.DBCommunicationGET
{
    public class GetDoctor
    {
        public List<Models.Model.Doctor> Execute()
        {
            List<Models.Model.Doctor> _doctor = new List<Models.Model.Doctor>();
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString.ConnString.ToString()))
                {
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand command = conn.CreateCommand();
                    command.CommandText = string.Format(@"SELECT * FROM  doktor;");
                    try
                    {
                        MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            _doctor.Add(new Models.Model.Doctor(reader));
                        }
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
            return _doctor;
        }
    }
}

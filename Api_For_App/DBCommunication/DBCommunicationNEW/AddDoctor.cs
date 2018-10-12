using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication.DBCommunicationNEW
{
    public class AddDoctor
    {
        public bool Execute(Doctor doctor)
        {
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString.ConnString.ToString()))
                {
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand command = conn.CreateCommand();
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@name",doctor.Name));
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@surname", doctor.Surname));
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@email", doctor.Email));
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@password", doctor.Password));
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@contact", doctor.Contact));
                    command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@location", doctor.Location));
                    command.CommandText = string.Format(@"INSERT INTO `ordinacija`.`doktor` (`Name`, `Surname`, `Email`, `Password`, `Contact`, `Location`) VALUES (@name, @surname, @email, @password, @contact, @location);");
                    try
                    {
                        MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();

                        return true;
                    }

                    catch (Exception ex)
                    {

                        return false;
                        throw ex;
                        
                    }
                }
               
            }
            catch(Exception ex)
            {
                
                return false;
                throw ex;
            }
        }
    }
}

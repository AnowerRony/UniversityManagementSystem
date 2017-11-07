using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.Models.EntityModels;

namespace UniversityManagementSystem.DAL
{
    public class UserGateway : CommonGateway
    {
        

        public int LogIn(string userName, string password)
        {
            string query = "SELECT COUNT(Id) FROM UserTable WHERE UserName = '" + userName + "' AND Password = '" + password +
                            "'";
            Connection.Open();
            Command.CommandText = query;
            SqlDataReader reader = Command.ExecuteReader();
            int count = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count += Convert.ToInt32(reader[0]);
                }
            }
            reader.Close();
            Connection.Close();
            return count;

        }
    }
}

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
            string query = "SELECT COUNT(Id) FROM UserTable WHERE UserName = '" + userName + "'COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = '" + password +
                            "'COLLATE SQL_Latin1_General_CP1_CS_AS";
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

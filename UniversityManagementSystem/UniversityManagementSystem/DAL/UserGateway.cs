using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Models.EntityModels;

namespace UniversityManagementSystem.DAL
{
    class UserGateway : CommonGateway
    {
        public List<User> GetAll()
        {
            string query = "SELECT * FROM User";
            Connection.Open();
            Command.CommandText = query;
            SqlDataReader reader = Command.ExecuteReader();
            List<User> users = new List<User>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = (int) reader["Id"];
                    user.UserName = reader["UserName"].ToString();
                    user.Password = reader["Password"].ToString();
                    users.Add(user);
                }
            }
            reader.Close();
            Connection.Close();
            return users;
        }
    }
}

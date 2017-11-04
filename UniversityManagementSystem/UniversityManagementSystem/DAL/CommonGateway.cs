using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using UniversityManagementSystem.Properties;
using System.Data;
using System.Windows.Forms;

namespace UniversityManagementSystem.DAL
{
    public class CommonGateway
    {
        //ConnectionStringSettings conSettings =
        //    ConfigurationManager.ConnectionStrings["UniversityManagementSystemConnectionString"];
        
        //string connectionString = conSett

        //public string connectionString =
        //    ConfigurationManager.ConnectionStrings["UniversityManagementSystemConnectionString"].ConnectionString;

        public string connectionString =
            ConfigurationManager.ConnectionStrings["UniversityManagementSystemConnectionString"].ConnectionString;
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }

        public CommonGateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }
    }
}

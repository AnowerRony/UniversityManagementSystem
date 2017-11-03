using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DAL;

namespace UniversityManagementSystem.BLL
{
    public class UserManager
    {
        UserGateway _userGateway = new UserGateway();

        public bool LogIn(string userName, string password)
        {
            int rowsAffected = _userGateway.LogIn(userName, password);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}

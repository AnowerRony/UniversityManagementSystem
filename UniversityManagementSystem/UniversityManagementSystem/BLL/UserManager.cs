using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.DAL;
using UniversityManagementSystem.Models.EntityModels;

namespace UniversityManagementSystem.BLL
{
    class UserManager
    {
        UserGateway _userGateway = new UserGateway();
        public List<User> GetAll()
        {
            return _userGateway.GetAll();
        }
    }
}

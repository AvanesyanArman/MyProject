using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL.Entities
{
    public class UsersAndAdmins
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public int Numbers { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public int? UserAccounts { get; set; }
        

    }
}

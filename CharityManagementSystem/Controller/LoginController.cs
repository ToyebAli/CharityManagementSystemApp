using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Controller
{
    public class LoginController
    {
        public Login SearchLogin(string userId, string password)
        {
            Logins lgs = new Logins();
            Login login = lgs.SearchLogin(userId, password);
            return login;
        }

        public void AddLogin(Login login)
        {
            Logins lgs = new Logins();
            lgs.AddLogin(login);
        }
    }
}

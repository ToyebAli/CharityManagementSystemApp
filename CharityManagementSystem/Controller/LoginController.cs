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

        public bool AddLogin(Login login)
        {
            Logins lgs = new Logins();
            lgs.AddLogin(login);
            return true;
        }

        public void UpdateLogin(Login login)
        {
            Logins lgs = new Logins();
            lgs.UpdateLogin(login);
        }

        public List<Login> GetAllLogin()
        {
            Logins lgs = new Logins();
            List<Login> loginList = lgs.GetAllLogin();
            return loginList;
        }

        public void DeleteLogin(string userId)
        {
            Logins lgs = new Logins();
            lgs.DeleteLogin(userId);
        }
    }
}

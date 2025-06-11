using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Login
    {
        private string userId;
        private string name;
        private string email;
        private string password;
        private string phoneNumber;
        private int role; // 1 for admin, 2 for donor, 3 for volunteer, 4 for beneficiary
        private string status;
        public Login()
        {

        }
        public Login(string userId, string name, string email, string password, string phoneNumber, int role, string status)
        {
            this.UserId = userId;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Role = role;
            this.Status = status;
        }

        public string UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Role { get => role; set => role = value; }
        public string Status { get => status; set => status = value; }

    }
}

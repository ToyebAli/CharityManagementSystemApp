using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.Controller
{
    public class RegisterController
    {
        public void AddRegister(Register reg)
        {
            Registers rgs = new Registers();
            rgs.AddRegister(reg);
        }

        public DataTable GetUserEventApplications()
        {
            Registers regs = new Registers();
            return regs.GetUserEventApplications();
        }

        public void DeleteRegister(string userId, string eventId)
        {
            Registers regs = new Registers();
            regs.DeleteRegister(userId, eventId);
        }
    }
}

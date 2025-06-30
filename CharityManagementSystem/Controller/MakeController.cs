using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Controller
{
    public class MakeController
    {
        public void AddMake(Make make)
        {
            Makes makes = new Makes();
            makes.AddMake(make);
        }

        public DataTable GetMakeUserJoinTable()
        {
            Makes makes = new Makes();
            return makes.GetMakeUserJoinTable();
        }
    }
}

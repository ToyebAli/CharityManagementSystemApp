using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;
using System.Data;

namespace CharityManagementSystem.Controller
{
    public class GivenController
    {
        public void AddGiven(Given given)
        {             
            Givens givens = new Givens();
            givens.AddGiven(given);
        }

        public DataTable GetGivenUserJoinTable()
        {
            Givens givens = new Givens();
            return givens.GetGivenUserJoinTable();
        }
    }
}

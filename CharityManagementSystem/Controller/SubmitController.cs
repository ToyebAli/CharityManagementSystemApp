using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.Controller
{
    public class SubmitController
    {
        public void AddSubmit(Submit submit)
        {
            Submits submits = new Submits();
            submits.AddSubmit(submit);
        }
        public string GetUserIdByAppId(string appId)
        {
            Submits submits = new Submits();
            return submits.GetUserIdByAppId(appId);
        }
    }
}

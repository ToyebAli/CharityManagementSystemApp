using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityManagementSystem.Model;

namespace CharityManagementSystem.Controller
{
    public class ApplicationController
    {
        public void AddApplication(Application app)
        {
            Applications applications = new Applications();
            applications.AddApplication(app);
        }

        public int GetPendingApplicationCount()
        {
            Applications applications = new Applications();
            return applications.GetPendingApplicationCount();
        }

        public List<Application> GetPendingApplications()
        {
            Applications apps = new Applications();
            return apps.GetPendingApplications();
        }

        public void UpdateApplicationStatus(string applicationId, string status)
        {
            Applications apps = new Applications();
            apps.UpdateApplicationStatus(applicationId, status);
        }
    }
}

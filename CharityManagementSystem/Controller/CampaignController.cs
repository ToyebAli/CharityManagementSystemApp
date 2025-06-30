using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Controller
{
    public class CampaignController
    {
        public void AddCampaign(Campaign cam)
        {
            Campaigns cps = new Campaigns();
            cps.AddCampaign(cam);
        }
        public List<Campaign> GetAllCampaigns()
        {
            Campaigns cps = new Campaigns();
            List<Campaign> campaignList = cps.GetAllCampaigns();
            return campaignList;
        }

        public void UpdateCollectedAmount(string camId, decimal newCollectedAmount)
        {
            Campaigns cps = new Campaigns();
            cps.UpdateCollectedAmount(camId, newCollectedAmount);
        }

        public void UpdateCampaign(Campaign cam)
        {
            Campaigns cps = new Campaigns();
            cps.UpdateCampaign(cam);
        }

        public void DeleteCampaign(string camId)
        {
            Campaigns cps = new Campaigns();
            cps.DeleteCampaign(camId);
        }
    }
}

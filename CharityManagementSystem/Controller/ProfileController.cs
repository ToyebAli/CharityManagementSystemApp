using CharityManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace CharityManagementSystem.Controller
{
    public class ProfileController
    {
        public void AddProfile(Profile profile)
        {
            Profiles prof = new Profiles();
            prof.AddProfile(profile);
        }

        public Profile SearchProfile(string userId)
        {
            Profiles pfs = new Profiles();
            Profile profile = pfs.SearchProfile(userId);
            return profile;
        }
    }
}

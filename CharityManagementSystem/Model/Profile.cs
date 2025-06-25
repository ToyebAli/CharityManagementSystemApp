using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityManagementSystem.Model
{
    public class Profile
    {
        private string profileId;
        private string address;
        private string dateOfBirth;
        private string gender;

        public Profile()
        {

        }

        public Profile(string profileId, string address, string dateOfBirth, string gender)
        {
            this.profileId = profileId;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        public string ProfileId { get => profileId; set => profileId = value; }
        public string Address { get => address; set => address = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }

    }
}

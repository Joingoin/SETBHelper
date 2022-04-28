using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETBHelper
{
    public class Attandee
    {

        public enum EnuRank : int
        {
            Enlist = 0,
            Cadet = 1,
            Private = 2,
            Corporal = 3,
            Sergant = 4,
            Master_Sergeant = 5,
            Warrant_Officer = 6,
            Lieutenant = 7,
            Captain = 8,
            Major = 9,
            Colonel = 10,
            O5 = 11,
            Overseer = 12,
            Administrator = 13
        }


        public string Name { get; private set; }
        public EnuRank Rank { get; private set; } = 0;
        public string DisplayName { get; private set; } = "";



        public Attandee(string _name,EnuRank _rank)
        {
            if(_name != "" && _name != null)
            {
                Name = _name;
            }
            else
            {
                MessageBox.Show("Invalid Name for Attendee! It will be listed as UnknownAttendee");
                Name = "UnknownAttendee";
            }

            Rank = _rank;
            DisplayName = "";
        }
        public Attandee(string _name, EnuRank _rank, string _dname)
        {
            if (_name != "" && _name != null)
            {
                Name = _name;
            }
            else
            {
                MessageBox.Show("Invalid Name for Attendee! It will be listed as UnknownAttendee");
                Name = "UnknownAttendee";
            }

            Rank = _rank;
            DisplayName = _dname;
        }

    }
}

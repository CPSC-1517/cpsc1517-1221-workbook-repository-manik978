using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manik_fall_1
{
    public class HockeyTeam
    {
        public enum HockeyConference
        {
            Eastern,
            Western
        }

        public enum HockeyDivision
        {
            Metropolitan,
            Atlantic,
            Central,
            Pacific
        }

        //Define Data for storing Data
        private HockeyConference _conference;
        private HockeyDivision _division;
        //Define fully-implementted properties for the data fields

        public HockeyConference Conference
        {
            get { return _conference; }
        }
        public HockeyDivision Division
        {
            get { return _division; }
        }
    }
}

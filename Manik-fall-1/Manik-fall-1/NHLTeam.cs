using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manik_fall_1
{
    public class NHLTeam
    {
        public NHLConference  Conference { get; private set; }
        public NHLDivision Division { get; private set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must contain text");
                }
                _name = value.Trim();
            }
        }
        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("City must conntain text");
                }
                _city = value.Trim();
            }
        }
        private int _GamePlayed;

            public int GamePlayed
        {
            get { return _GamePlayed; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Gameplayed sholud not be less zero");
                }
                _GamePlayed = value;
            }
        }
        private int _Wins;

        public int Wins
        {
            get { return _Wins; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Wins shoud be greater than zero");
                }
                _Wins = value;
            }
        }

        private int _Losses;

        public int Losses
        {
            get { return _Losses; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Losses should be greater than zero");
                }
                _Losses = value;
            }

        }
        private int _Overtimelosses;

        public int Overtimelosses
        {
            get { return _Overtimelosses; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Overtimelosses should be grater than zero");
                }
                _Overtimelosses = value;
            }
        }

        private int _Points;

        public int Points
        {
            get => (Wins * 2) + Overtimelosses; 
        }

        public NHLTeam(NHLConference conference, NHLDivision division, string name, string city)
        {
            Conference  = conference;
            Division = division;    
            Name = name;
            City = city;


            GamePlayed = 0;
            Wins = 0;
            Losses= 0;
            Overtimelosses = 0;
        }

        public override string ToString()
        {
            return $"{Conference},{Division},{Name}, {City}, {GamePlayed}, {Wins}, {Losses}, {Overtimelosses}";
        }




    }
}

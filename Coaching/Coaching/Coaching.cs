using System;
using System.Collections.Generic;
using System.Text;

namespace Coaching
{
    class Coaching
    {
        /*
         * four (4) pieces of information as auto-implemented properties
         * the coaching type (sport) (type string)
         * the number of players (type int) - validation that > 0 players
         * class timings (type string)
         * charges (type double)
         */

        private string sportType;
        public string SportType { get; set; }

        private int numPlayers;
        public int NumPlayers
        {
            get
            {
                return numPlayers;
            }
            set
            {
                if (value > 0)
                {
                    numPlayers = value;
                }
            }
        }
        private string classTimings;
        public string ClassTimings { get; set; }

        private double charges;
        public double Charges
        {
            get
            {
                return charges;
            }
            set
            {
                if (value > 0)
                {
                    charges = value;
                }
            }
        }

        /*
         *  constructor that initializes the four automatic properties and assumes that the values are provided
         */

        public Coaching (string stype, int nplayers, string ctimings, double chrgs)
        {
            SportType = stype;
            NumPlayers = nplayers;
            ClassTimings = ctimings;
            Charges = chrgs;
        }


        /*
         * method DisplayDetails that displays all the information. The charges should be represented as $
         */

        public void DisplayDetails()
        {
            Console.WriteLine($"Sport type: {SportType}. Number of players: {NumPlayers}. Class timings: {ClassTimings}. Charges: {Charges:c}.");
        }
    }
}

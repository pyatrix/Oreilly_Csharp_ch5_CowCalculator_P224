using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch5_CowCalculator_P224
{
    class Farmer
    {
        public int NumberOfCows;
        public int FeedMultiplier { get; }
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.FeedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;            
        }
        private int bagsOfFeed;
        public int BagsOfFeed
        {
            get
            {
                BagsOfFeed = NumberOfCows * FeedMultiplier;
                return bagsOfFeed;
            }
            set
            {
                bagsOfFeed = value;
            }
        }
    }
}
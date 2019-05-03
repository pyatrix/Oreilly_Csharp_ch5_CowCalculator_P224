using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch5_CowCalculator_P224
{
    class Farmer
    {        
        public int BagsOfFeed { get { return numberOfCows * FeedMultiplier; } } //it without propertie of  [set].
        public const int FeedMultiplier = 30;
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                //BagsOfFeed = numberOfCows * FeedMultiplier;      //replaced by [public int BagsOfFeed { get { return numberOfCows * FeedMultiplier; } }]
            }
        }
    }
}
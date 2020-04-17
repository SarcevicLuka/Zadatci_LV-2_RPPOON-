using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_LV2_RPPOON
{
    /*Zadatak 1.
    class Die
    {
        private int numberOfSIdes;
        private Random randomGenerator;

        
        public Die(int numberOfSides)             
        {
            this.numberOfSIdes = numberOfSides;
            this.randomGenerator = new Random();
        }

        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSIdes + 1);
            return rolledNumber;
        }
    }*/

    /*Zadatak 2.
    class Die
    {
        private int numberOfSIdes;
        private Random randomGenerator;

        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSIdes = numberOfSides;
            this.randomGenerator = randomGenerator;
        }

        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSIdes + 1);
            return rolledNumber;
        }
    }*/

    /*Zadatci 3,4.
    class Die
    {
        private int numberOfSIdes;
        private RandomGenerator randomGenerator = RandomGenerator.GetInstance();

        public Die(int numberOfSides)
        {
            this.numberOfSIdes = numberOfSides;
        }

        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSIdes + 1);
            return rolledNumber;
        }
    }*/

}

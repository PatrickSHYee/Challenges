using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTimes = 10000;
            FlipCoins(numOfTimes);
            FlipForHeads(numOfTimes);

            // debugger stopper
            Console.WriteLine("Any key to continue...");
            Console.ReadKey();
        }

        static void FlipCoins(int numberOfFlips)
        {
            int numberOfHeads = 0;
            int numberOfTails = 0;
            int headsOrTails;
            Random randGen = new Random();

            for (int n = 0; n < numberOfFlips; n++)
            {
                headsOrTails = randGen.Next(0, 2);

                if (headsOrTails == 0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }

            // prints out number of flips, heads, and tails.
            Console.WriteLine("We flipped a coin {0} times.", numberOfFlips);
            Console.WriteLine("Number of Heads: {0}", numberOfHeads);
            Console.WriteLine("Number of Tails: {0}", numberOfTails);
        }

        static void FlipForHeads(int numberOfHeads)
        {
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            int headsOrTails;
            Random randGen = new Random();

            while (numberOfHeadsFlipped != numberOfHeads)
            {
                headsOrTails = randGen.Next(0, 2);
                totalFlips++;
                if (headsOrTails == 0) numberOfHeadsFlipped++;
            }

            Console.WriteLine("We are flipping a coin until we find {0} heads.", numberOfHeads);
            Console.WriteLine("It took {0} to find {1} heads", totalFlips, numberOfHeads);
        }
    }
}

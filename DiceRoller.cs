using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        // Property to get the array storing roll totals
        public int[] rollTotals { get; private set; }
        // Constructor initializes the array for roll totals
        public DiceRoller()
        {
            rollTotals = new int[13];
        }

        // Method to simulate rolling the dice a specified number of times
        public int[] Rolling(int numRolls)
        {

            Random random = new Random();

            //Loop for the number of times the user specified
            for (int i = numRolls; i > 0; i--)
            {

                // Roll the first die
                int die1 = random.Next(1, 7);
                // Roll the second die
                int die2 = random.Next(1, 7);

                //Calculate the total of the two dice
                int total = die1 + die2;

                // Increment the count for the corresponding total in the array
                rollTotals[total]++;



            }
            //Return the array with roll totals
            return rollTotals;

        }
    }
}


using System;
using System.Xml.Linq;

namespace Mission2 {
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create an instance of the DiceRoller class
            DiceRoller dr = new DiceRoller();

            // Prompt the user to enter the number of times to roll the dice
            System.Console.WriteLine("How many times do you want to roll the dice?");
            int numRolls = int.Parse(System.Console.ReadLine());

            //Call the Rolling method of DiceRoller class, but the result is not used
       // dr.Rolling(numRolls);


            // Call the Rolling method again and store the result in diceArray
            int[] diceArray = dr.Rolling(numRolls);

            // Loop through the array to print the distribution of dice rolls
            for (int i = 2; i < diceArray.Length; i++)
            {
                // Calculate the percentage for the current index
                int percent = (diceArray[i] * 100) / numRolls;

                // Print the index and a number of '*' characters based on the percentage
                Console.Write($"{i}: ");
                for (int j = 0; j < percent; j++)
                {
                    Console.Write('*');
                }

                // Move to the next line for the next index
                Console.WriteLine();

            }


        }
    }
}
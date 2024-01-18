
using System;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create an instance of the DiceRoller class
        DiceRoller dr;
        dr = new DiceRoller();

        // Prompt the user to enter the number of times to roll the dice
        System.Console.WriteLine("How many times do you want to roll the dice?");
        int numRolls = int.Parse(System.Console.ReadLine());

        //Call the Rolling method of DiceRoller class, but the result is not used
        dr.Rolling(numRolls);


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


internal class DiceRoller
{
    // Property to get the array storing roll totals
    public int[] rollTotals
    {
        get; private set;
    }
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
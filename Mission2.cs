
using System;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        DiceRoller dr;
        dr = new DiceRoller();


        System.Console.WriteLine("How many times do you want to roll the dice?");
        int numRolls = int.Parse(System.Console.ReadLine());

        //send numRolls to the other class??
        dr.Rolling(numRolls);


        //int[] diceArray = new int[13];
        //diceArray = dr.Rolling(numRolls);
        int[] diceArray = dr.Rolling(numRolls);


        for (int i = 2; i < diceArray.Length; i++)
        {
            int percent = (diceArray[i] * 100) / numRolls;
            Console.Write($"{i}: ");

            for (int j = 0; j < percent; j++)
            {
                Console.Write('*');
            }

            Console.WriteLine();

        }


    }
}


internal class DiceRoller
{
    public int[] rollTotals
    {
        get; private set;
    }
    public DiceRoller()
    {
        rollTotals = new int[13];
    }
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


            int total = die1 + die2;

            rollTotals[total]++;



        }

        return rollTotals;

    }
}
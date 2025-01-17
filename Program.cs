using MissionTwo_Jaden;
public class Program
{
    private static void Main(string[] args)
    {
        //Initialize variables
        int numRolls = 0;
        int[,] rollStats = { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, 
            { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 12, 0 } };
        string userInput = ""; //store temporary inputs from the user
        DiceRoll dr = new DiceRoll();


        //Welcome user
        Console.WriteLine("Which dice combo is rolled most often? We're about to find out!");
        Console.WriteLine("You will be rolling two dice at a time.");
        Console.Write("How many dice rolls would you like?: ");
        userInput = Console.ReadLine();


        //Check to see if user input is a number, then store value
        while (!int.TryParse(userInput, out numRolls))
        {
            Console.WriteLine("\nYou done messed up A-aron. That's not a real number.");
            Console.Write("How many dice rolls would you like?: ");
            userInput = Console.ReadLine();
        }
        numRolls = Convert.ToInt32(userInput);



        Console.WriteLine($"\nNow rolling {numRolls} time(s)."); //I prefer string interpolation over concatenation

        //Dice rolling commences
        dr.RollTheDice(numRolls, rollStats);


        //Display results: for testing only
        //Console.WriteLine("\n\nHere's how often each dice combo was rolled.");
        //for (int i = 0; i < rollStats.GetLength(0); i++)
        //{
        //    for (int j = 0; j < rollStats.GetLength(1); j++)
        //    {
        //        Console.Write(rollStats[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}


    }

}
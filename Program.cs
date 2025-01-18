using MissionTwo_Jaden;
public class Program
{
    private static void Main(string[] args)
    {
        //Initialize variables
        double numRolls = 0;
        int[,] rollResults = { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, 
            { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 12, 0 } }; //column 0 contains combined roll, column 1 contains occurrances
        double[,] rollPercents = { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 },
            { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 12, 0 } };
        string userInput = ""; //store temporary inputs from the user
        DiceRoll dr = new DiceRoll();



        //Welcome user
        Console.WriteLine("Which dice combo is rolled most often? We're about to find out!");
        Console.WriteLine("You will be rolling two dice at a time.");
        Console.Write("How many dice rolls would you like?: ");
        userInput = Console.ReadLine();



        //Check to see if user input is a number, then store value
        while (!double.TryParse(userInput, out numRolls))
        {
            Console.WriteLine("\nYou done messed up A-aron. That's not a real number.");
            Console.Write("How many dice rolls would you like?: ");
            userInput = Console.ReadLine();
        }
        numRolls = Convert.ToDouble(userInput);



        //Dice rolling commences
        Console.WriteLine($"\nNow rolling {numRolls} time(s)."); //I prefer string interpolation over concatenation
        rollResults = dr.RollTheDice(numRolls, rollResults);


        ////for testing return values
        //Console.WriteLine("results");
        //for (int i = 0; i < rollResults.GetLength(0); i++)
        //{
        //    for (int j = 0; j < rollResults.GetLength(1); j++)
        //    {
        //        Console.Write(rollResults[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}



        //Calculate percentages
        for (int i = 0; i < rollResults.GetLength(0); i++)
        {
            rollPercents[i, 1] = rollResults[i, 1] / numRolls;
            rollPercents[i, 1] = Math.Round(rollPercents[i, 1] * 100, 0);
            //Console.WriteLine($"{rollResults[i, 1]} / {numRolls} = {rollResults[i, 1] / numRolls}"); //for testing

        }


        ////For testing
        Console.WriteLine("\n\npercentages");
        for (int i = 0; i < rollPercents.GetLength(0); i++)
        {
            for (int j = 0; j < rollPercents.GetLength(1); j++)
            {
                Console.Write(rollPercents[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        //Display percentages
        for (int i = 0 ; i < rollPercents.GetLength(0); i++)
        {
            Console.Write($"{rollPercents[i, 0]}: ");
            for (int j = 0 ; j < rollPercents[i, 1]; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }




    }

}
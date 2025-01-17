using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionTwo_Jaden
{
    internal class DiceRoll //I'm keeping this internal for security purposes
    {
        public void RollTheDice(int rollCount, int[,] diceArray)
        {

            //initialize variables
            int dice1 = 0;
            int dice2 = 0;
            int combinedRoll = 0;
            Random rand = new Random();



            //get dice results
            for (int i = 0; i < rollCount; i++) 
            {
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);

                combinedRoll = dice1 + dice2;
                Console.WriteLine($"Dice roll: {combinedRoll}");
            }




            for (int i = 0; i < diceArray.GetLength(0); i++)
            {
                for (int j = 0; j < diceArray.GetLength(1); j++)
                {
                    Console.Write(diceArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace die_using_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DiceUno = new int[6];
            Random rnd = new Random();

            Console.WriteLine("This program will allow you to roll one dice");
            Console.WriteLine("\nAs many times as you want");
            Console.WriteLine("\n\nWhen you want to exit the program, please type (exit)");
            Console.WriteLine("\nPress any key to begin rolling");
            Console.Read();


            for (int i = 0; i < 1; i++)
            {
                int diceRoll = 0;
                diceRoll = rnd.Next(6);
                DiceUno[diceRoll]++;
                Console.WriteLine("Dice 1 is rolled a: {0}", diceRoll + 1);
                diceRoll = rnd.Next(6);
            

            }





        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI352Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random lottery = new Random();
            int number = 0;
            int userGuess = 0;
            int attempts = 0;
            int x = 0;
            int y = 0;

            Console.WriteLine("I'm going to guess a number. What 2 numbers do you want it to be between?");

            Console.Write("Lowest Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Highest Number: ");
            y = Convert.ToInt32(Console.ReadLine());

            number = lottery.Next(x, y);

            Console.WriteLine();
            Console.WriteLine("I'm thinking of a number between {0} and {1}.", x, y);
            userGuess = GetGuess(number);

            while (userGuess != number)
            {

                if (userGuess < number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too LOW.");
                    attempts++;
                    userGuess = GetGuess(number);
                }

                if (userGuess > number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too HIGH.");
                    attempts++;
                    userGuess = GetGuess(number);
                }
            }

            if (userGuess == number)
            {
                Console.WriteLine();
                Console.WriteLine("You got it!");
                attempts++;
                Console.WriteLine("It took you {0} tries.", attempts);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }

        static public int GetGuess(int number)
        {
            int userGuess = 0;

            Console.Write("What do you think it is? - ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            return userGuess;
        }

    }

}

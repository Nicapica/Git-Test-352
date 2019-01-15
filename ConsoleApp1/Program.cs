using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Random random = new Random();
            int counter = 1;
            int guess = 0;
            int result = random.Next(0, 100);
            Console.WriteLine("Guess what number I am thinking of");
            while (guess != result)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > result)
                {
                    Console.WriteLine("Incorrect, guess is to high");
                    ++counter;
                }
                else if (guess < result)
                {
                    Console.WriteLine("Incorrect, guess is to low");
                    ++counter;
                }
                else if (guess == result)
                {
                    Console.WriteLine("Congrats, you guessed it!");
                    Console.WriteLine("Tries: " + counter);
                }

            }
            Console.ReadLine();
        }
    }
}

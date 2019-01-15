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
            int x = 0;
            int y = 0;
            int counter = 1;
            int guess = 0;
            Console.WriteLine("pick a higher bound number and then a lower bound number for our number guessing game!");
            Console.WriteLine("pick a higher bound number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pick a higher bound number");
            y = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int result = random.Next(0, 100);
            Console.WriteLine("Guess the number!");
            while (guess != result)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > result)
                {
                    Console.WriteLine("oops, guess is to high");
                    ++counter;
                }
                else if (guess < result)
                {
                    Console.WriteLine("oops, guess is to low");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizz_buzz_game
{
    class Program
    {
        static void Main()
        {

            int fizz = 3, buzz = 5, numbers, userInput;

            Console.WriteLine("welcome to the fizzbuzz game, today we are using numbers between 1 to 15!");
            Console.WriteLine("");
            Console.Write("Now you can write which numbers from X to Y will be fizz, buzz or a Fizbuzz!!: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (numbers = 1; numbers <= userInput; numbers++)
            {
                if (numbers % fizz == 0 && numbers / buzz == 3)
                {
                    Console.WriteLine("the number {0} is a fizzbuzz!!!", numbers);
                }
                else if (numbers % fizz == 0)
                {
                    Console.WriteLine("the number {0} is a fizz", numbers);
                }
                else if (numbers % buzz == 0)
                {
                    Console.WriteLine("the number {0} is a buzz", numbers);
                }
                else {
                    Console.WriteLine(numbers);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to close the terminal! :)");
            Console.ReadLine();
        }
    }
}
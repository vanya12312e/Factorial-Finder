using System;

namespace HelloWorld
{
    public class SearchFactorial
    {
        public long Factorial(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }

    class Program
    {
        private static void Main()
        {
            SearchFactorial searchFactorial = new SearchFactorial();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************");
            Console.WriteLine("* Welcome to the Factorial Finder *");
            Console.WriteLine("**********************************");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWrite the number whose factorial you want to find: ");
                Console.ResetColor();

                string input = Console.ReadLine();
                if (long.TryParse(input, out long number))
                {
                    long result = searchFactorial.Factorial(number);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nThe factorial of {number} is: ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress Enter to continue or type 'exit' to quit.");
                Console.ResetColor();

                if (Console.ReadLine().Trim().ToLower() == "exit")
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThank you for using the Factorial Finder!");
            Console.WriteLine("***************************************");
            Console.ResetColor();

        }
    }
}

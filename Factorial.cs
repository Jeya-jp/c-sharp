using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1, n;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            while (number > 0)
            {
                fact = fact * number;
                number = number - 1;
            }
            Console.WriteLine("The factorial of " + n + " is " + fact);
            Console.ReadKey();
        }
    }
}

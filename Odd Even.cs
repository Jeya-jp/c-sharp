using System;
namespace Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number.");
            }
            else
            {
                Console.WriteLine(number + " is an odd number.");
            }
            Console.ReadKey();
        }
    }
}

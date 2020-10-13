using System;
namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, count=0;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
            Console.ReadKey();
        }
    }
}

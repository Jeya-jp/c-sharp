using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = -1, n2 = 1, n3, number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("The Fibonacci Series is ");
            for (int i = 0; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write("\n" + n3);
                n1 = n2;
                n2 = n3;
            }
            Console.ReadKey();
        }
    }
}

using System;
namespace Large_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            int[] elements = new int[number];
            Console.WriteLine("Enter the numbers: ");
            for (int temp = 0; temp < number; temp++)
            {
                elements[temp] = int.Parse(Console.ReadLine());
            }
            int large = elements[0];
            for (int big = 1; big < elements.Length; big++)
            {
                if (large < elements[big])
                {
                    large = elements[big];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(large +" is the largest number.");
            Console.ReadLine();
        }
    }
}

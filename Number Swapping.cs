using System;
namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter the 1st value: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd value: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping:");
            Console.WriteLine("X value = " + x);
            Console.WriteLine("Y value = " + y);
            Console.WriteLine("After Swapping:");
            z = y;
            y = x;
            Console.WriteLine("X value = " + z);
            Console.WriteLine("Y value = " + y);
            Console.ReadKey();
        }
    }
}

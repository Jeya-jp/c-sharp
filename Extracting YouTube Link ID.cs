using System;
namespace Extract_ID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code only for YouTube Link
            // Eg: Short url: https://youtu.be/fP6G8ca0aU4
            // Eg: Long url: https://www.youtube.com/watch?v=fP6G8ca0aU4
            string url, result, final;
            Console.Write("Enter the short url: ");
            url = Console.ReadLine();
            result = url.Substring(url.LastIndexOf("/"));
            final = result.Substring(1);
            Console.WriteLine("The video ID is: "+ final);
            Console.Write("Enter the long url: ");
            url = Console.ReadLine();
            result = url.Substring(url.LastIndexOf("="));
            final = result.Substring(1);
            Console.Write("The video ID is: " + final);
            Console.ReadKey();
        }
    }
}

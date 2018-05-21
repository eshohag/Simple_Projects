using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Simple Apps");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number-" + i);
            }

            Console.WriteLine("Enter your Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine(phoneNumber);
            
            Console.WriteLine("Hello Test Simple Project Branch!");
            Console.ReadKey();
        }
    }
}
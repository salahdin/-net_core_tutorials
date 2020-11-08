using System;

namespace _net_core_tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey whats your name?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name},on {date:d} at{date:t}!");
            Console.WriteLine("\n Press any key to exit .....");
            Console.ReadKey(true);

        }
    }
}

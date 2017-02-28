using NullObjectPattern.Model;
using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter car name:");
            var carName = Console.ReadLine();

            var bmw = VehichleHelper.Find(carName);
            bmw.Start();
            bmw.Stop();

            Console.ReadKey();
        }
    }
}

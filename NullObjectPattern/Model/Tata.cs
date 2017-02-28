using NullObjectPattern.Model.Interface;
using System;

namespace NullObjectPattern.Model
{
    public class Tata : IVehichle
    {
        public string Name { get; set; }

        public Tata()
        {
            Name = "Tata";
        }

        public void Start()
        {
            Console.WriteLine($"{Name} Started!");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} Stopped!");
        }
    }
}

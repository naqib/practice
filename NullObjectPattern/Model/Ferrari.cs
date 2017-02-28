using NullObjectPattern.Model.Interface;
using System;

namespace NullObjectPattern.Model
{
    public class Ferrari : IVehichle
    {
        public string Name { get; set; }

        public Ferrari()
        {
            Name = "Ferrari";
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

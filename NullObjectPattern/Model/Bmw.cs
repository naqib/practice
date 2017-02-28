using NullObjectPattern.Model.Interface;
using System;

namespace NullObjectPattern.Model
{
    public class Bmw : IVehichle
    {
        public string Name { get; set; }

        public Bmw()
        {
            Name = "Bmw";
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

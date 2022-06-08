using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Cat : Pet
    {
        public Cat(string name, string description, int years, int weight, string color, int speed)
        {
            Name = name;
            Description = description;
            Years = years;
            Weight = weight;
            Color = color;
            Speed = speed;
        }
        public override void Voice()
        {
            Console.WriteLine("voice - meow");
        }
    }
}

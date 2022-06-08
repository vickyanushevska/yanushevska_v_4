using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Parrot : Bird
    {
        public Parrot(string name, string description, int years, int weight, string color, int speed) : base(name, description, years, weight, color, speed)
        {
            Name = name;
            Description = description;
            Years = years;
            Weight = weight;
            Color = color;
            Speed = speed;
        }
    }
}

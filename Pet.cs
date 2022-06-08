using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    abstract class Pet //суперклас
    {
        public string Name { get; set; } //параметри
        public int Years { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public abstract void Voice();

        public override string ToString()
        {
            return $"{Name} ( {Years} years; {Weight} kg;  {Speed} km/h ) {Color} {Description} ";
        }
    }

    class HomePet
    {
        public void Voice(Pet pet) { pet.Voice(); }

        public List<Pet> pets { get; set; }

        public HomePet()
        {
            pets = new List<Pet>();
        }

        public void AddPet()
        {
            Dog dog = new Dog("1.pet - DOG Fire", "\nskill - executes commands", 5, 25, "\ncolor - black", 20); 
            Cat cat = new Cat("\v2.pet - CAT Boomer", "\nskill - sleeps all day", 2, 10, "\ncolor - gray", 10);
            Bird bird = new Bird("\v3.pet - BIRD Inokentii", "\nskill - eats food in large quantities", 2, 1, "\ncolor - white", 40);
            Parrot parrot = new Parrot("\v4.pet - PARROT Kesha", "\nskill - says tongue twisters", 1, 1, "\ncolor - red", 30);

            pets.Add(dog); pets.Add(cat); pets.Add(bird); pets.Add(parrot);
        }

        public void Information()
        {
            foreach (var pts in pets)
            {
                Console.WriteLine(pts.ToString());
                Voice(pts);
            }

        }

        public double TopWeight()
        {
            double maxWeight = 0;
            foreach (Pet pet in pets)
            {
                if (pet.Weight > maxWeight)
                    maxWeight = pet.Weight;
            }
            return maxWeight;
        }

        public double TopSpeed()
        {
            double maxSpeed = 0;
            foreach (Pet pet in pets)
            {
                if (pet.Speed > maxSpeed)
                    maxSpeed = pet.Speed;
            }
            return maxSpeed;
        }

        public double TopAge()
        {
            double maxAge = 0;
            foreach (Pet pet in pets)
            {
                if (pet.Years > maxAge)
                    maxAge = pet.Years;
            }
            return maxAge;
        }
    }
}

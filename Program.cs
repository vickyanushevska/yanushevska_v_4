/*Створити суперклас Домашня тварина і підкласи Собака, Кішка, Папуга, Птах. 
  За допомогою конструктора встановити ім'я кожної тварини і його характеристики. 
  Вивести на екран голос, який подає домашня тварина*/

using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePet homePet = new HomePet();
            homePet.AddPet();
            Console.WriteLine("Pets and their characteristics:");
            Console.WriteLine("------------------------------------------------------------");
            homePet.Information();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Maximum weight among animals: {homePet.TopWeight()} kg");
            Console.WriteLine($"Maximum speed among animals: {homePet.TopSpeed()} km/h");
            Console.WriteLine($"Maximum age among animals: {homePet.TopAge()} years");
        }
    }
}

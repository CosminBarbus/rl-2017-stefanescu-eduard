using HelloWorld.BussinessLogic;
using System;

namespace HelloWorld.ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            var animals = AnimalFactory.CreateQuadrupedAnimals();

            foreach (var animal in animals)
                AnimalSound.MakeNoise(animal);

            Console.ReadKey();
        }
    }
}

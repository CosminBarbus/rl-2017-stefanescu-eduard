using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Duck duck = new Duck();
            Horse horse = new Horse();

            Sound animalSounds = new Sound();

            Lion lion = new Lion();
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(duck);
            animals.Add(horse);
            animals.Add(lion);
            animals.Add(cat);
            animals.Add(dog);

            foreach (Animal a in animals)
            {
                animalSounds.MakeNoise(a);
            }

            Console.ReadKey();
        }
    }
}

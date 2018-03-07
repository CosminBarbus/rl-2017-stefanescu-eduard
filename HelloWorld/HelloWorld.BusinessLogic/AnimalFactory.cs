using HelloWorld.BussinessLogic.Animals;
using System.Collections.Generic;

namespace HelloWorld.BussinessLogic
{
    public static class AnimalFactory
    {
        public static IEnumerable<IAnimal> CreateQuadrupedAnimals()
        {
            IList<IAnimal> animals = new List<IAnimal>();

            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Horse());
            animals.Add(new Lion());
            animals.Add(new Tiger());

            return animals;
        }

        public static IEnumerable<IAnimal> CreateBipedAnimals()
        {
            IList<IAnimal> animals = new List<IAnimal>();

            animals.Add(new Duck());
            animals.Add(new Dove());
            animals.Add(new Falcon());
            animals.Add(new Owl());
            animals.Add(new Penguin());

            return animals;
        }
    }
}

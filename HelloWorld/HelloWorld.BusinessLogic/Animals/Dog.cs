namespace HelloWorld.BussinessLogic.Animals
{
    public class Dog : IAnimal
    {
        public string Name()
        {
            return "Dog";
        }
        public string Noise()
        {
            return "woof";
        }
    }
}

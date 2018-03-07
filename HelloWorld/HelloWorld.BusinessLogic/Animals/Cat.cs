namespace HelloWorld.BussinessLogic.Animals
{
    public class Cat : IAnimal
    {
        public string Name()
        {
            return "Cat";
        }
        public string Noise()
        {
            return "meow";
        }
    }
}

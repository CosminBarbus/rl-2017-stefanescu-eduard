namespace HelloWorld.BussinessLogic.Animals
{
    public class Owl : IAnimal
    {
        public string Name()
        {
            return "Owl";
        }

        public string Noise()
        {
            return "hoot, hiss";
        }
    }
}

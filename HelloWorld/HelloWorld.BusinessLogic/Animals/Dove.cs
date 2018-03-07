namespace HelloWorld.BussinessLogic.Animals
{
    public class Dove : IAnimal
    {
        public string Name()
        {
            return "Dove";
        }

        public string Noise()
        {
            return "coo";
        }
    }
}

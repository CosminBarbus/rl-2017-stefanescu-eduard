namespace HelloWorld.BussinessLogic.Animals
{
    public class Duck : IAnimal
    {
        public string Name()
        {
            return "Duck";
        }
        public string Noise()
        {
            return "quack";
        }
    }
}

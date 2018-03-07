namespace HelloWorld.BussinessLogic.Animals
{
    public class Horse : IAnimal
    {
        public string Name()
        {
            return "Horse";
        }
        public string Noise()
        {
            return "neigh";
        }
    }
}

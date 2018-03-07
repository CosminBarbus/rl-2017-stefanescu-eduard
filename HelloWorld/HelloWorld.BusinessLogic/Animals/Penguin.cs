namespace HelloWorld.BussinessLogic.Animals
{
    public class Penguin : IAnimal
    {
        public string Name()
        {
            return "Penguin";
        }

        public string Noise()
        {
            return "gak";
        }
    }
}

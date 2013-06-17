namespace Strategy.Duck
{
    public class Squeak : IQuackBehavior
    {
        public string Quacking()
        {
            return "Squeak";
        }
    }
}
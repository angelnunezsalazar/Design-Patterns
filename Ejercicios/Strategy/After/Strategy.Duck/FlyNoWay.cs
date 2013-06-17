namespace Strategy.Duck
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly.";
        }
    }
}
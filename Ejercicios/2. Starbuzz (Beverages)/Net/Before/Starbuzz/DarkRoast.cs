namespace Starbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public double Cost()
        {
            return .99 + CondimentCost();
        }
    }
}

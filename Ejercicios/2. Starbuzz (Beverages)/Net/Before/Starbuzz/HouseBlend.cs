namespace Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public double Cost()
        {
            return .89 + CondimentCost();
        }
    }
}

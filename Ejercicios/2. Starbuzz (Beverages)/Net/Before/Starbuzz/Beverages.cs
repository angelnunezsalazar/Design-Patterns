namespace Starbuzz
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public bool HasMilk { get; set; }
        public bool HasSoy { get; set; }
        public bool HasMocha { get; set; }
        public bool HasWhip { get; set; }

        public double CondimentCost()
        {
            double condimentCost = 0.0;
            if (HasMilk)
            {
                double milkCost = 0.1;
                condimentCost += milkCost;
            }
            if (HasSoy)
            {
                double soyCost = 0.15;
                condimentCost += soyCost;
            }
            if (HasMocha)
            {
                double mochaCost = 0.2;
                condimentCost += mochaCost;
            }
            if (HasWhip)
            {
                double whipCost = 0.1;
                condimentCost += whipCost;
            }
            return condimentCost;
        }
    }
}

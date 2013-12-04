namespace Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Expresso";
        }

        public double Cost()
        {
            return 1.99 + CondimentCost(); ;
        }
    }
}

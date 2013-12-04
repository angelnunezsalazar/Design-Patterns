namespace Starbuzz
{
    public class Mocha : CondimentDecorator
	{
		Beverage beverage;
		
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override double Cost()
		{
            return .20 + this.beverage.Cost();
		}
	}
}

namespace Starbuzz
{
	public class Milk : CondimentDecorator
	{
		Beverage beverage;
		
		public Milk(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override double Cost()
		{
			return .10 + this.beverage.Cost();
		}
	}
}

namespace Starbuzz
{
	public class Whip : CondimentDecorator
	{
		Beverage beverage;
		
		public Whip(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override double Cost()
		{
			return .10 + this.beverage.Cost();
		}
	}
}

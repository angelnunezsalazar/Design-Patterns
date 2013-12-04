namespace Starbuzz
{
	public class Soy : CondimentDecorator
	{
		Beverage beverage;
		
		public Soy(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override double Cost()
		{
			return .15 + this.beverage.Cost();
		}
	}
}

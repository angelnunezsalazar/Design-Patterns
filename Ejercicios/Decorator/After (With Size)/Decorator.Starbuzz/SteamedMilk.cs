namespace Decorator.Starbuzz
{
	public class SteamedMilk : CondimentDecorator
	{
		Beverage beverage;
		
		public SteamedMilk(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string GetDescription()
		{
			return this.beverage.GetDescription() + ", Steamed Milk";
		}

		public override double Cost()
		{
			return .10 + this.beverage.Cost();
		}
	}
}

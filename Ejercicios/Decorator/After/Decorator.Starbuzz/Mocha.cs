namespace Decorator.Starbuzz
{
    using System;
    using System.Configuration;

	public class Mocha : CondimentDecorator
	{
		Beverage beverage;
		
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string GetDescription()
		{
			return this.beverage.GetDescription() + ", Mocha";
		}

		public override double Cost()
		{
            return .20 + this.beverage.Cost();
		}
	}
}

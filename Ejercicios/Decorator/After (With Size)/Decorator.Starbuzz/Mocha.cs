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
			return this.GetSize(base.Size);
		}

		private double GetSize(BeverageSize size)
		{
			switch(size)
			{
				case BeverageSize.TALL:
					return Convert.ToDouble(ConfigurationSettings.AppSettings["MochaSizeTall"]) + 
						this.beverage.Cost();
				case BeverageSize.GRANDE:
					return  Convert.ToDouble(ConfigurationSettings.AppSettings["MochaSizeGrande"]) + 
						this.beverage.Cost();
				case BeverageSize.VENTI:
					return  Convert.ToDouble(ConfigurationSettings.AppSettings["MochaSizeVenti"]) + 
						this.beverage.Cost();
				default:
					return .20;
			}
		}

	}
}

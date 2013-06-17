namespace Decorator.Starbuzz
{
    using System;
    using System.Configuration;

	public class Expresso: Beverage
	{
	    public override double Cost()
		{
			return this.GetSize(base.Size);
		}

		public override string GetDescription()
		{
			return "Expresso";
		}

		private double GetSize(BeverageSize size)
		{
			switch(size)
			{
				case BeverageSize.TALL:
					return Convert.ToDouble(ConfigurationSettings.AppSettings["ExpressoSizeTall"]);
				case BeverageSize.GRANDE:
					return Convert.ToDouble(ConfigurationSettings.AppSettings["ExpressoSizeGrande"]);
				case BeverageSize.VENTI:
					return Convert.ToDouble(ConfigurationSettings.AppSettings["ExpressoSizeVenti"]);
				default:
					return 1.50;
			}
		}

	}
}

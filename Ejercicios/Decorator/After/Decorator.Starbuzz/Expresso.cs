namespace Decorator.Starbuzz
{
    using System;
    using System.Configuration;

	public class Expresso: Beverage
	{
	    public override double Cost()
	    {
	        return 1.99;
	    }

		public override string GetDescription()
		{
			return "Expresso";
		}
	}
}

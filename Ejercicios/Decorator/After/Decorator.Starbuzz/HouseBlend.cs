namespace Decorator.Starbuzz
{
	public class HouseBlend : Beverage
	{
	    public override double Cost()
		{
			return .89;
		}

		public override string GetDescription()
		{
			return "House Blend Coffee";
		}
	}
}

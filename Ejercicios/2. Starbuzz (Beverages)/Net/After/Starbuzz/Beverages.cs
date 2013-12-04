namespace Starbuzz
{
	public abstract class Beverage
	{
        protected string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

	    public abstract double Cost();
	}
}

package starbuzz;  

public abstract class Beverage {
	String description = "Unknown Beverage";
	
	private boolean hasMilk;
	private boolean hasWhip;
	private boolean hasMocha;
	private boolean hasSoy;
	
	public double condimentCost(){
		double condimentCost = 0.0;
        if (hasMilk)
        {
            double milkCost = 0.1;
            condimentCost += milkCost;
        }
        if (hasSoy)
        {
            double soyCost = 0.15;
            condimentCost += soyCost;
        }
        if (hasMocha)
        {
            double mochaCost = 0.2;
            condimentCost += mochaCost;
        }
        if (hasWhip)
        {
            double whipCost = 0.1;
            condimentCost += whipCost;
        }
        return condimentCost;
	}

	public String getDescription() {
		return description;
	}
	
	public boolean getHasMilk() {
		return hasMilk;
	}

	public void setHasMilk(boolean hasMilk) {
		this.hasMilk = hasMilk;
	}

	public boolean getHasWhip() {
		return hasWhip;
	}

	public void setHasWhip(boolean hasWhip) {
		this.hasWhip = hasWhip;
	}

	public boolean getHasMocha() {
		return hasMocha;
	}

	public void setHasMocha(boolean hasMocha) {
		this.hasMocha = hasMocha;
	}

	public boolean getHasSoy() {
		return hasSoy;
	}

	public void setHasSoy(boolean hasSoy) {
		this.hasSoy = hasSoy;
	}
}

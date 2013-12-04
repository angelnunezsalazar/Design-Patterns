package starbuzz;
 
public class Whip extends CondimentDecorator {
	Beverage beverage;
 
	public Whip(Beverage beverage) {
		this.beverage = beverage;
	}

	public double cost() {
		return .10 + beverage.cost();
	}
}

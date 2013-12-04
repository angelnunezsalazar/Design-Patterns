package starbuzz;

public class Soy extends CondimentDecorator {
	Beverage beverage;

	public Soy(Beverage beverage) {
		this.beverage = beverage;
	}
	
	public double cost() {
		return .15 + beverage.cost();
	}
}

package starbuzz;

public class Milk extends CondimentDecorator {
	Beverage beverage;

	public Milk(Beverage beverage) {
		this.beverage = beverage;
	}

	public double cost() {
		return .10 + beverage.cost();
	}
}

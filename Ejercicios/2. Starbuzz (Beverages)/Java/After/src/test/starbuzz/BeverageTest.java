package starbuzz;

import static org.junit.Assert.*;

import org.junit.Test;

public class BeverageTest {

	private static final double DELTA = 0.00001;

	@Test
	public void Expresso() {
		Beverage beverage = new Espresso();
		assertEquals(1.99, beverage.cost(), DELTA);
	}

	@Test
	public void HouseBlendWithSoyWithMochaWithWhip() {
		Beverage beverage = new HouseBlend();
		beverage = new Soy(beverage);
		beverage = new Mocha(beverage);
		beverage = new Whip(beverage);

		assertEquals(1.34, beverage.cost(), DELTA);
	}

	@Test
	public void DarkRoastWithMochaWithWhipWithMilk() {
		Beverage beverage = new DarkRoast();
		beverage = new Mocha(beverage);
		beverage = new Whip(beverage);
		beverage = new Milk(beverage);
		assertEquals(1.39, beverage.cost(), DELTA);
	}
}

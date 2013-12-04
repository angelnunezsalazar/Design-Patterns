package starbuzz;

import static org.junit.Assert.*;

import org.junit.Test;

public class BeverageTest {

	private static final double DELTA = 0.00001;

	@Test
	public void Expresso() {
		Espresso beverage = new Espresso();
		assertEquals(1.99, beverage.cost(), DELTA);
	}

	@Test
	public void HouseBlendWithSoyWithMochaWithWhip() {
		HouseBlend beverage = new HouseBlend();
		beverage.setHasSoy(true);
		beverage.setHasMocha(true);
		beverage.setHasWhip(true);

		assertEquals(1.34, beverage.cost(), DELTA);
	}

	@Test
	public void DarkRoastWithMochaWithWhipWithMilk() {
		DarkRoast beverage = new DarkRoast();
		beverage.setHasMocha(true);
		beverage.setHasWhip(true);
		beverage.setHasMilk(true);
		assertEquals(1.39, beverage.cost(), DELTA);
	}
}

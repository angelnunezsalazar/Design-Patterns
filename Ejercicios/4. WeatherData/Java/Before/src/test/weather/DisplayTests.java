package weather;

import static org.junit.Assert.*;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class DisplayTests {
	private final ByteArrayOutputStream outContent = new ByteArrayOutputStream();

	@Before
	public void setUp() {
		System.setOut(new PrintStream(outContent));
	}

	@Test
	public void UpdateDisplay1() {
		WeatherData weatherData = new WeatherData();
		weatherData.setMeasurements(80, 65, 30.4f);

//		assertTrue(this.outContent.toString().contains(
//				"Current conditions: 80F degrees and 65% humidity"));
		assertTrue(this.outContent.toString().contains("Improving weather on the way!"));
		assertTrue(this.outContent.toString().contains("Avg/Max/Min temperature = 80.0F/80.0F/80.0F"));
	}

	@Test
	public void UpdateDisplay2() {
		WeatherData weatherData = new WeatherData();
		weatherData.setMeasurements(82, 70, 29.2f);

//		assertTrue(this.outContent.toString().contains(
//				"Current conditions: 82F degrees and 70% humidity"));
		assertTrue(this.outContent.toString().contains(
				"Watch out for cooler, rainy weather"));
		assertTrue(this.outContent.toString().contains(
				"Avg/Max/Min temperature = 82.0F/82.0F/82.0F"));
	}

	@After
	public void tearDown() {
		System.setOut(null);
	}

}

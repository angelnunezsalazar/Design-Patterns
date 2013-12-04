package gumballmachine;

import static org.junit.Assert.*;
import gumballmachine.GumballMachine;
import gumballmachine.MachineMessages;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class GumballMachineTest {

	private final static int NO_GUMBALLS=0;
	private final ByteArrayOutputStream outContent = new ByteArrayOutputStream();

	@Before
	public void setUp() {
		System.setOut(new PrintStream(outContent));
	}

	@After
	public void tearDown() {
		System.setOut(null);
	}

	@Test
	public void insertQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();

		this.assertMachineMessage(MachineMessages.YouInsertedAQuarter);
	}

	@Test
	public void insertQuarterTwice() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();
		gumballMachine.insertQuarter();

		this.assertMachineMessage(MachineMessages.YoutCantInsertAnotherQuarter);
	}

	@Test
	public void insertWhenSoldOut() {
		GumballMachine gumballMachine = createGumballMachine(NO_GUMBALLS);

		gumballMachine.insertQuarter();

		this.assertMachineMessage(MachineMessages.MachineIsSoldOut);
	}

	@Test
	public void ejectQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();
		gumballMachine.ejectQuarter();

		this.assertMachineMessage(MachineMessages.QuarterReturned);
	}

	@Test
	public void ejectWhenNoQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.ejectQuarter();

		this.assertMachineMessage(MachineMessages.YouHaventInsertedAQuarter);
	}

	@Test
	public void ejectWhenSoldOut() {
		GumballMachine gumballMachine = createGumballMachine(NO_GUMBALLS);

		gumballMachine.ejectQuarter();

		this.assertMachineMessage(MachineMessages.NoQuarterToEject);
	}

	@Test
	public void turnWhenSoldOut() {
		GumballMachine gumballMachine = createGumballMachine(NO_GUMBALLS);

		gumballMachine.turnCrank();

		this.assertMachineMessage(MachineMessages.TurnedButThereIsNoGumballs);
	}

	@Test
	public void turnWhenNoQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.turnCrank();

		this.assertMachineMessage(MachineMessages.TurnedButThereisNoQuarter);
	}

	@Test
	public void dispense() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();

		this.assertMachineMessage(MachineMessages.TurnedSuccessfully);
		this.assertMachineMessage(MachineMessages.GumballComesRollingOut);
	}

	@Test
	public void dispenseTheLastGumball() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();
		gumballMachine.insertQuarter();
		gumballMachine.turnCrank();

		this.assertMachineMessage(MachineMessages.OutOfGumballs);
	}

	@Test
	public void dispenseWhenNoQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.dispense();

		this.assertMachineMessage(MachineMessages.YoutNeedToPayFirst);
	}

	@Test
	public void dispenseWhenHasQuarter() {
		GumballMachine gumballMachine = createGumballMachine(1);

		gumballMachine.insertQuarter();
		gumballMachine.dispense();

		this.assertMachineMessage(MachineMessages.NoGumballDispensed);
	}

	@Test
	public void dispenseWhenSoldOut() {
		GumballMachine gumballMachine = createGumballMachine(NO_GUMBALLS);

		gumballMachine.dispense();

		this.assertMachineMessage(MachineMessages.NoGumballDispensed);
	}

	private static GumballMachine createGumballMachine(int count) {
		GumballMachine gumballMachine = new GumballMachine(count);
		return gumballMachine;
	}

	private void assertMachineMessage(String message) {
		assertTrue (this.outContent.toString().contains(message));
	}

}

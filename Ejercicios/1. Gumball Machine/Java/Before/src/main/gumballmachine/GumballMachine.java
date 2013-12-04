package gumballmachine;

public class GumballMachine {

	final static int SOLD_OUT = 0;
	final static int NO_QUARTER = 1;
	final static int HAS_QUARTER = 2;
	final static int SOLD = 3;

	private int state = SOLD_OUT;
	private int count = 0;

	public GumballMachine(int count) {
		this.count = count;
		if (count > 0) {
			state = NO_QUARTER;
		}
	}

	public void insertQuarter() {
		if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.YouCantInsertAnotherQuarter);
		} else if (state == NO_QUARTER) {
			state = HAS_QUARTER;
			System.out.println(MachineMessages.PleaseWaitYourGumball);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.MachineIsSoldOut);
		} else if (state == SOLD) {
			System.out.println(MachineMessages.PleaseWaitYourGumball);
		}
	}

	public void ejectQuarter() {
		if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.QuarterReturned);
			state = NO_QUARTER;
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.YouHaventInsertedAQuarter);
		} else if (state == SOLD) {
			System.out.println(MachineMessages.AlreadyTurnedTheCrank);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.NoQuarterToEject);
		}
	}

	public void turnCrank() {
		if (state == SOLD) {
			System.out.println(MachineMessages.TurningTwice);
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.TurnedButThereIsNoQuarter);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.TurnedButThereIsNoGumballs);
		} else if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.TurnedSuccessfully);
			state = SOLD;
			dispense();
		}
	}

	public void dispense() {
		if (state == SOLD) {
			System.out.println(MachineMessages.GumballComesRollingOut);
			count = count - 1;
			if (count == 0) {
				System.out.println(MachineMessages.OutOfGumballs);
				state = SOLD_OUT;
			} else {
				state = NO_QUARTER;
			}
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.YouNeedToPayFirst);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.NoGumballDispensed);
		} else if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.NoGumballDispensed);
		}
	}
}

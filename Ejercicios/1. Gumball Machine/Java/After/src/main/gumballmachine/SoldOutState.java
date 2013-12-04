package gumballmachine;

public class SoldOutState implements State {
    GumballMachine gumballMachine;
 
    public SoldOutState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
 
	public void insertQuarter() {
		System.out.println(MachineMessages.MachineIsSoldOut);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.NoQuarterToEject);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnedButThereIsNoGumballs);
	}
 
	public void dispense() {
		System.out.println(MachineMessages.NoGumballDispensed);
	}
}

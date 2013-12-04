package gumballmachine;

public class HasQuarterState implements State {
	GumballMachine gumballMachine;
 
	public HasQuarterState(GumballMachine gumballMachine) {
		this.gumballMachine = gumballMachine;
	}
  
	public void insertQuarter() {
		System.out.println(MachineMessages.YoutCantInsertAnotherQuarter);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.QuarterReturned);
		gumballMachine.setState(gumballMachine.getNoQuarterState());
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnedSuccessfully);
		gumballMachine.setState(gumballMachine.getSoldState());
		gumballMachine.dispense();
	}

    public void dispense() {
        System.out.println(MachineMessages.NoGumballDispensed);
    }
}

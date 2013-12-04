package gumballmachine;

public class NoQuarterState implements State {
    GumballMachine gumballMachine;
 
    public NoQuarterState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
 
	public void insertQuarter() {
		System.out.println(MachineMessages.YouInsertedAQuarter);
		gumballMachine.setState(gumballMachine.getHasQuarterState());
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.YouHaventInsertedAQuarter);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnedButThereisNoQuarter);
	 }
 
	public void dispense() {
		System.out.println(MachineMessages.YoutNeedToPayFirst);
	} 
}

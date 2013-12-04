package gumballmachine;

public class SoldState implements State {
 
    GumballMachine gumballMachine;
 
    public SoldState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
       
	public void insertQuarter() {
		System.out.println(MachineMessages.PleaseWaitYourGumball);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.AlreadyTurnedTheCrank);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurningTwice);
	}
 
	public void dispense() {
		gumballMachine.releaseBall();
		if (gumballMachine.getCount()== 0) {
			gumballMachine.setState(gumballMachine.getSoldOutState());
			System.out.println(MachineMessages.OutOfGumballs);
		} else {
			gumballMachine.setState(gumballMachine.getNoQuarterState());
		}
	}
}



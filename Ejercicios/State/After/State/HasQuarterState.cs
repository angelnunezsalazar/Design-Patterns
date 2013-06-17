namespace State
{
    using System;

    internal class HasQuarterState : IState
    {
        private readonly GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertTwice);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectSuccessfully);
            this.gumballMachine.State = this.gumballMachine.NoQuarter;
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnSuccessfully);
            this.gumballMachine.State = this.gumballMachine.Sold;
            this.gumballMachine.Dispense();
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenHasQuarter);
        }
    }
}
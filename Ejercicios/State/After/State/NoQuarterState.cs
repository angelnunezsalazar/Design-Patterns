namespace State
{
    using System;

    internal class NoQuarterState : IState
    {
        private readonly GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            this.gumballMachine.State = this.gumballMachine.HasQuarter;
            Console.WriteLine(MachineMessages.InsertSuccessfully);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenNoQuarter);
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnWhenNoQuarter);
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenNoQuarter);
        }
    }
}
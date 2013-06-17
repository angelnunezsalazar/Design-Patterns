namespace State
{
    using System;

    internal class SoldState : IState
    {
        private readonly GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertWhenSold);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenSold);
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnTwice);
        }

        public void Dispense()
        {
            this.gumballMachine.ReleaseBall();
            if (this.gumballMachine.Count == 0)
            {
                Console.WriteLine(MachineMessages.DispenseTheLastGumball);
                this.gumballMachine.State = this.gumballMachine.SoldOut;
            }
            else
            {
                this.gumballMachine.State = this.gumballMachine.NoQuarter;
            }
        }
    }
}
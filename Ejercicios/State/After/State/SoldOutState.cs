namespace State
{
    using System;

    internal class SoldOutState : IState
    {
        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertWhenSoldOut);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenSoldOut);
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnWhenSoldOut);
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenSoldOut);
        }
    }
}
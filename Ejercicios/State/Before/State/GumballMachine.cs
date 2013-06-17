namespace State
{
    using System;

    public class GumballMachine
    {
        public const int SOLD_OUT = 0;
        public const int NO_QUARTER = 1;
        public const int HAS_QUARTER = 2;
        public const int SOLD = 3;

        int state = SOLD_OUT;
        int count;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                this.state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (this.state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.InsertTwice);
            }
            else if (this.state == NO_QUARTER)
            {
                this.state = HAS_QUARTER;
                Console.WriteLine(MachineMessages.InsertSuccessfully);
            }
            else if (this.state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.InsertWhenSoldOut);
            }
            else if (this.state == SOLD)
            {
                Console.WriteLine(MachineMessages.InsertWhenSold);
            }
        }

        public void EjectQuarter()
        {
            if (this.state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.EjectSuccessfully);
                this.state = NO_QUARTER;
            }
            else if (this.state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.EjectWhenNoQuarter);
            }
            else if (this.state == SOLD)
            {
                Console.WriteLine(MachineMessages.EjectWhenSold);
            }
            else if (this.state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.EjectWhenSoldOut);
            }
        }

        public void TurnCrank()
        {
            if (this.state == SOLD)
            {
                Console.WriteLine(MachineMessages.TurnTwice);
            }
            else if (this.state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.TurnWhenNoQuarter);
            }
            else if (this.state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.TurnWhenSoldOut);
            }
            else if (this.state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.TurnSuccessfully);
                this.state = SOLD;
                this.Dispense();
            }
        }

        public void Dispense()
        {
            if (this.state == SOLD)
            {
                Console.WriteLine(MachineMessages.DispenseSuccessfully);
                this.count = this.count - 1;
                if (this.count == 0)
                {
                    Console.WriteLine(MachineMessages.DispenseTheLastGumball);
                    this.state = SOLD_OUT;
                }
                else
                {
                    this.state = NO_QUARTER;
                }
            }
            else if (this.state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.DispenseWhenNoQuarter);
            }
            else if (this.state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.DispenseWhenSoldOut);
            }
            else if (this.state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.DispenseWhenHasQuarter);
            }
        }
    }
}
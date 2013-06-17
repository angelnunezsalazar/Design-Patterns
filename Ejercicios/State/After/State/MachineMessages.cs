namespace State
{
    public class MachineMessages
    {
        public const string InsertTwice = "You can't insert another quarter";

        public const string InsertSuccessfully = "You inserted a quarter";

        public const string InsertWhenSoldOut = "You can't insert a quarter, the machine is sold out";

        public const string InsertWhenSold = "Please wait, we're already giving you a gumball";

        public const string EjectSuccessfully = "Quarter returned";

        public const string EjectWhenNoQuarter = "You haven't inserted a quarter";

        public const string EjectWhenSoldOut = "You can't eject, you haven't inserted a quarter yet";

        public const string EjectWhenSold = "You already turned the crank";

        public const string TurnWhenNoQuarter = "You turned but there's no quarter";

        public const string TurnTwice = "Turning twice doesn't get you another gumball!";

        public const string TurnWhenSoldOut = "You turned, but there are no gumballs";

        public const string TurnSuccessfully = "You turned...";

        public const string DispenseWhenNoQuarter = "You need to pay first";

        public const string DispenseTheLastGumball = "Oops, out of gumballs!";

        public const string DispenseWhenSoldOut = "No gumball dispensed";

        public const string DispenseSuccessfully = "A gumball comes rolling out the slot";

        public const string DispenseWhenHasQuarter = "No gumball dispensed";
    }
}
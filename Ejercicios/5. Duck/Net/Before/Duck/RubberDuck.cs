namespace Duck
{
    public class RubberDuck : Duck
    {
        public override object Fly()
        {
            return DuckMessages.CantFly;
        }

        public override object Quack()
        {
            return DuckMessages.Squeak;
        }

        public override object Display()
        {
            return DuckMessages.RubberDisplay;
        }
    }
}
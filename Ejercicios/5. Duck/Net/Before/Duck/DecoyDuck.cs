namespace Duck
{
    public class DecoyDuck : Duck
    {
        public override object Fly()
        {
            return DuckMessages.CantFly;
        }

        public override object Quack()
        {
            return DuckMessages.Silence;
        }

        public override object Display()
        {
            return DuckMessages.ModelDisplay;
        }
    }
}
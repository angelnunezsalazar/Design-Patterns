namespace Strategy.Duck
{
    public class RubberDuck : Duck
    {
        public override object Fly()
        {
            return "I can't fly.";
        }

        public override object Quack()
        {
            return "Squeak";
        }

        public override object Display()
        {
            return "I'm a rubber duck";
        }
    }
}
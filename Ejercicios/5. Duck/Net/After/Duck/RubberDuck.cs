namespace Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.QuackBehavior = new Squeak();
            this.FlyBehavoir = new FlyNoWay();
        }

        public override object Display()
        {
            return "I'm a rubber duck";
        }
    }
}
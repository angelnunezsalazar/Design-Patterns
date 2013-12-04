namespace Strategy.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.QuackBehavior = new Quack();
            this.FlyBehavoir = new FlyWithWings();
        }

        public override object Display()
        {
            return "I'm a real Mallard duck";
        }
    }
}
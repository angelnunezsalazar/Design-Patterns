namespace Strategy.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyBehavoir = new FlyNoWay();
            this.QuackBehavior = new MuteQuack();
        }

        public override object Display()
        {
            return "I'm a model duck";
        }
    }
}
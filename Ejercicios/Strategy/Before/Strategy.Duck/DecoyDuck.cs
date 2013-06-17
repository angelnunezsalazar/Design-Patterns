namespace Strategy.Duck
{
    public class DecoyDuck : Duck
    {
        public override object Fly()
        {
            return "I can't fly.";
        }

        public override object Quack()
        {
            return "<<silence>>";
        }

        public override object Display()
        {
            return "I'm a model duck";
        }
    }
}
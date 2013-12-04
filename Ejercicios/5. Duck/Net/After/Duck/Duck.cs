namespace Strategy.Duck
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { get; set; }

        public IFlyBehavior FlyBehavoir { get; set; }

        public abstract object Display();

        public object PerformFly()
        {
            return this.FlyBehavoir.Fly();
        }

        public object PerformQuack()
        {
            return this.QuackBehavior.Quacking();
        }

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }
    }
}
namespace Strategy.Duck
{
    public abstract class Duck
    {
        public virtual object Fly()
        {
            return "I'm flying!!";
        }

        public virtual object Quack()
        {
            return "Quack";
        }

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }

        public abstract object Display();
    }
}
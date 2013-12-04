namespace Duck
{
    public abstract class Duck
    {
        public virtual object Fly()
        {
            return DuckMessages.Fly;
        }

        public virtual object Quack()
        {
            return DuckMessages.Quack;
        }

        public string Swim()
        {
            return DuckMessages.Swim;
        }

        public abstract object Display();
    }
}
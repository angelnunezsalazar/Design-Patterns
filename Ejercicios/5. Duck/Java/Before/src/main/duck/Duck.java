package duck;

public abstract class Duck {
    public Object fly()
    {
        return DuckMessages.Fly;
    }

    public Object quack()
    {
        return DuckMessages.Quack;
    }

    public String swim()
    {
        return DuckMessages.Swim;
    }

    public abstract Object display();
}

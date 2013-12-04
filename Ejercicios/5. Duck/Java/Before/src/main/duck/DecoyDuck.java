package duck;

public class DecoyDuck  extends Duck{
    public Object fly()
    {
        return DuckMessages.CantFly;
    }

    public Object quack()
    {
        return DuckMessages.Silence;
    }

    public Object display()
    {
        return DuckMessages.ModelDisplay;
    }
}

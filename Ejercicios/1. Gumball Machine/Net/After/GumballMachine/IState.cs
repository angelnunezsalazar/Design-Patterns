namespace GumballMachine
{
    public interface IState
    {
        void Insert();

        void Eject();

        void Turn();

        void Dispense();
    }
}
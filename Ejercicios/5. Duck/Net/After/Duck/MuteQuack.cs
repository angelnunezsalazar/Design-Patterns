namespace Duck
{
    public class MuteQuack : IQuackBehavior
    {
        public string Quacking()
        {
            return "<<silence>>";
        }
    }
}
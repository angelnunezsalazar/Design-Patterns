namespace TemplateMethod.CaffeineBeverage
{
    public class Tea : CaffeineBeverage
    {
        public override string Brew()
        {
            return "Steeping the tea\n";
        }

        public override string AddCondiments()
        {
            return "Adding lemon\n";
        }
    }
}
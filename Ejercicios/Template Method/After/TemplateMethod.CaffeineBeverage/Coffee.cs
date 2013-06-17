namespace TemplateMethod.CaffeineBeverage
{
    public class Coffee : CaffeineBeverage
    {
        public override string Brew()
        {
            return "Dripping coffee through filter\n";
        }

        public override string AddCondiments()
        {
            return "Adding sugar and milk\n";
        }
    }
}
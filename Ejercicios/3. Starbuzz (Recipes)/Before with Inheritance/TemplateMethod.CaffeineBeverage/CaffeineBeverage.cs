namespace TemplateMethod.CaffeineBeverage
{
    public abstract class CaffeineBeverage
    {
        public abstract string PrepareRecipe();

        public string BoilWater()
        {
            return "Boiling water\n";
        }

        public string PourInCup()
        {
            return "Pouring into cup\n";
        }
    }
}
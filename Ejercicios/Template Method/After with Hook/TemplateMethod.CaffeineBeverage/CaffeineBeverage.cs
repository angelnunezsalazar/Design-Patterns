namespace TemplateMethod.CaffeineBeverage
{
    using System.Text;

    public abstract class CaffeineBeverage
    {
        public string PrepareRecipe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.BoilWater());
            sb.Append(this.Brew());
            sb.Append(this.PourInCup());
            if (this.CustomerWantsCondiments())
            {
                sb.Append(this.AddCondiments());
            }

            return sb.ToString();
        }

        public abstract string Brew();

        public abstract string AddCondiments();

        private string BoilWater()
        {
            return "Boiling water\n";
        }

        private string PourInCup()
        {
            return "Pouring into cup\n";
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
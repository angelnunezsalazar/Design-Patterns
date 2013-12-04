namespace TemplateMethod.CaffeineBeverage
{
    using System.Text;

    public class Tea
    {
        public string PrepareRecipe()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.BoilWater());
            sb.Append(this.SteepTeaBag());
            sb.Append(this.PourInCup());
            sb.Append(this.AddLemon());

            return sb.ToString();
        }

        public string SteepTeaBag()
        {
            return "Steeping the tea\n";
        }

        public string AddLemon()
        {
            return "Adding lemon\n";
        }

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
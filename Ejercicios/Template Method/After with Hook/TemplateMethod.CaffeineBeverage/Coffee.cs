namespace TemplateMethod.CaffeineBeverage
{
    using System;
    using System.Configuration;

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

        public override bool CustomerWantsCondiments()
        {
            return Convert.ToBoolean(ConfigurationSettings.AppSettings["WantCodiments?"]);
        }
    }
}
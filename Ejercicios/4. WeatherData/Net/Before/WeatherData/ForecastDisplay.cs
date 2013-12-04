using System.Text;

namespace WeatherData
{
    public class ForcastDisplay : IDisplayElement
    {
        private float currentPressure = 29.92f;

        private float lastPressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = pressure;
        }

        public object Display()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Forecast: ");

            if (this.currentPressure > this.lastPressure)
            {
                sb.Append("Improving weather on the way!");
            }
            else if (this.currentPressure == this.lastPressure)
            {
                sb.Append("More of the same");
            }
            else if (this.currentPressure < this.lastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather");
            }
            return sb.ToString();
        }
    }
}
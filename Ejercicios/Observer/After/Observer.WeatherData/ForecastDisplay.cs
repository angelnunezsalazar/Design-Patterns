namespace Observer.WeatherData
{
    using System.Text;

    public class ForcastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;

        private float lastPressure;

        private ISubject weatherData;

        public ForcastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

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
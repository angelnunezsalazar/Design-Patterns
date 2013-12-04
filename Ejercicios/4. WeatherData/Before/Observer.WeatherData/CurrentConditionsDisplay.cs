namespace Observer.WeatherData
{
    /// <summary>
    /// Summary description for CurrentConditionsDisplay.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplayElement
    {
        private float temperature;

        private float humidity;

        private float pressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public object Display()
        {
            return "Current conditions: " + this.temperature +
                   "F degrees and " + this.humidity + "% humidity";
        }
    }
}
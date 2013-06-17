namespace Observer.WeatherData
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;

        private float humidity;

        private float pressure;

        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

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
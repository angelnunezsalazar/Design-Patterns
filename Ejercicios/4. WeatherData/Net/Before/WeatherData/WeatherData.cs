namespace WeatherData
{
    public class WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
        private ForecastDisplay forecastDisplay = new ForecastDisplay();
        private StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

        public void MeasurementsChanged()
        {
            currentConditionsDisplay.Update(temperature, humidity, pressure);
            forecastDisplay.Update(temperature, humidity, pressure);
            statisticsDisplay.Update(temperature, humidity, pressure);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
namespace Observer.WeatherData
{
    public class WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
        private ForcastDisplay forecastDisplay = new ForcastDisplay();
        private StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

        public void MeasurementsChanged()
        {
            this.currentConditionsDisplay.Update(this.temperature, this.humidity, this.pressure);
            this.forecastDisplay.Update(this.temperature, this.humidity, this.pressure);
            this.statisticsDisplay.Update(this.temperature, this.humidity, this.pressure);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
package weather;

public class WeatherData {
    private float temperature;
    private float humidity;
    private float pressure;

    private CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
    private ForecastDisplay forecastDisplay = new ForecastDisplay();
    private StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

    public void MeasurementsChanged()
    {
        currentConditionsDisplay.update(temperature, humidity, pressure);
        forecastDisplay.update(temperature, humidity, pressure);
        statisticsDisplay.update(temperature, humidity, pressure);
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}

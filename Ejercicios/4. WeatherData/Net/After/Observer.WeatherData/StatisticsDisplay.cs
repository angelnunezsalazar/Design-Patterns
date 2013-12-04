namespace Observer.WeatherData
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;

        private float minTemp = 200;

        private float temperatureSum = 0.0f;

        private int numReadings = 0;

        private ISubject weatherData;

        public int NumberOfReadings
        {
            get
            {
                return this.numReadings;
            }
        }

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperatureSum += temperature;
            this.numReadings++;

            if (temperature > this.maxTemp)
            {
                this.maxTemp = temperature;
            }

            if (temperature < this.minTemp)
            {
                this.minTemp = temperature;
            }
        }

        public object Display()
        {
            return "Avg/Max/Min temperature = " + RoundFloatToString(this.temperatureSum / this.numReadings) +
                   "F/" + this.maxTemp + "F/" + this.minTemp + "F";
        }

        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }
    }
}
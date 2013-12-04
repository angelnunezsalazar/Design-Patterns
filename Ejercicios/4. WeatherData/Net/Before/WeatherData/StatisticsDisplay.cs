using System;

namespace WeatherData
{
    public class StatisticsDisplay : IDisplayElement
    {
        private float maxTemp = 0.0f;

        private float minTemp = 200;

        private float temperatureSum = 0.0f;

        private int numReadings = 0;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperatureSum += temperature;
            this.numReadings++;

            if (temperature > maxTemp)
            {
                this.maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                this.minTemp = temperature;
            }
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (this.temperatureSum / this.numReadings).ToString("F") +
                   "F/" + this.maxTemp + "F/" + this.minTemp + "F");
        }
    }
}
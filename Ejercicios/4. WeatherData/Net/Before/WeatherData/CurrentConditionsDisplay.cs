using System;

namespace WeatherData
{
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
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + this.temperature + "F degrees and " + this.humidity + "% humidity");
        }
    }
}
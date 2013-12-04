namespace Observer.WeatherData
{
    using System.Collections;

    public class WeatherData : ISubject
    {
        private ArrayList observers;

        private float temperature;

        private float humidity;

        private float pressure;

        public WeatherData()
        {
            this.observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = this.observers.IndexOf(o);
            if (i >= 0)
            {
                this.observers.Remove(o);
            }
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObserver();
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
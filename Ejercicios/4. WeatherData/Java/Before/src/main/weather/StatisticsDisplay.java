package weather;

public class StatisticsDisplay {
    private float maxTemp = 0.0f;

    private float minTemp = 200;

    private float temperatureSum = 0.0f;

    private int numReadings = 0;

    public void update(float temperature, float humidity, float pressure)
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
        display();
    }

    public void display()
    {
    	System.out.println("Avg/Max/Min temperature = " + Float.toString(this.temperatureSum / this.numReadings) +
               "F/" + this.maxTemp + "F/" + this.minTemp + "F");
    }
}

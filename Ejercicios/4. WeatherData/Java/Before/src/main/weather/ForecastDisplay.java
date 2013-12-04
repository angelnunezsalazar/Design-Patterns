package weather;

public class ForecastDisplay implements DisplayElement {
    private float currentPressure = 29.92f;

    private float lastPressure;

    public void update(float temperature, float humidity, float pressure)
    {
        this.lastPressure = this.currentPressure;
        this.currentPressure = pressure;
        display();
    }

    public void display()
    {
        StringBuilder sb = new StringBuilder();

        sb.append("Forecast: ");

        if (this.currentPressure > this.lastPressure)
        {
            sb.append("Improving weather on the way!");
        }
        else if (this.currentPressure == this.lastPressure)
        {
            sb.append("More of the same");
        }
        else if (this.currentPressure < this.lastPressure)
        {
            sb.append("Watch out for cooler, rainy weather");
        }
        System.out.println(sb.toString());
    }
}

namespace WeatherStation;

public class DisplayCurrentConditions(ISubject dataSource) : Display(dataSource)
{
    public override void ShowDisplay()
    {
        Console.WriteLine($"Conditions:\nTemp: {this.temperature}\tHumidity: {this.humidity}%");
    }
    // Pack parameters to something like eventArgs?
    public override void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        ShowDisplay();
    }
}

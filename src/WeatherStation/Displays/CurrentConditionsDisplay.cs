namespace WeatherStation;

public class CurrentConditionsDisplay : IDisplay, IObserver
{
    private float temperature;
    private float humidity;
    private ISubject dataSource; // WeatherData in orig, but why lol?
    public CurrentConditionsDisplay(ISubject dataSource)
    {
        this.dataSource = dataSource;
        dataSource.AddObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Conditions:\nTemp: {this.temperature}\tHumidity: {this.humidity}%");
    }
    // Pack parameters to something like eventArgs?
    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }
}

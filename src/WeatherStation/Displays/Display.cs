namespace WeatherStation;

public abstract class Display : IDisplay, IObserver
{
    protected float temperature;
    protected float humidity;
    protected ISubject dataSource; // WeatherData in orig, but why lol?

    protected Display(ISubject dataSource)
    {
        this.dataSource = dataSource;
        dataSource.AddObserver(this);
    }

    public abstract void Update(float temperature, float humidity, float pressure);

    public abstract void ShowDisplay();

}

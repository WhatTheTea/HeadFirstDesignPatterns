namespace WeatherStation;

public sealed class WeatherData : ISubject
{
    private List<IObserver> observers = [];
    private float temperature;
    private float humidity;
    private float pressure;
    public void AddObserver(IObserver observer) => observers.Add(observer);

    public void RemoveObserver(IObserver observer) => observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementsChanged() => NotifyObservers();
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;

        MeasurementsChanged();
    }
}

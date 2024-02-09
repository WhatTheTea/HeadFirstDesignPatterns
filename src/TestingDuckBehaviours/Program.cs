namespace TestingDuckBehaviours;

public class Program 
{
    public static void Main()
    {
        Duck duck = new DuckMallard();
        duck.Display();
        duck.Quack();
        duck.Fly();
    }
}

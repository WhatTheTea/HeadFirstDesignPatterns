namespace TestingDuckBehaviours;
/// <summary>
/// Strategy pattern implementation from HFDP
/// </summary>
public class Program 
{
    public static void Main()
    {
        Duck duck = new DuckMallard();
        duck.Display();
        duck.Quack();
        duck.Fly();

        Duck duck1 = new DuckGround();
        duck1.Display();
        duck1.Quack();
        duck1.Fly();
        duck1.SetFlyBehaviour(new FlyRocket());
        duck1.Fly();
    }
}

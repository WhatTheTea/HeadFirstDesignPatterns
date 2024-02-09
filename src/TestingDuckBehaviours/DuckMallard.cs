namespace TestingDuckBehaviours;

public class DuckMallard : Duck
{
    public DuckMallard()
    {
        quackBehaviour = new Quack();
        flyBehaviour = new FlyWings();
    }
    public override void Display()
    {
        Console.WriteLine("Mallard Duck!");
    }
}

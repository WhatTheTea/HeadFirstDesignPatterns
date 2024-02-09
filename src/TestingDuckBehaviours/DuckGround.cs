namespace TestingDuckBehaviours;

public class DuckGround : Duck
{
    public DuckGround()
    {
        quackBehaviour = new Quack();
        flyBehaviour = new FlyNot();
    }
    public override void Display()
    {
        Console.WriteLine("Grounded duck :(");
    }
}

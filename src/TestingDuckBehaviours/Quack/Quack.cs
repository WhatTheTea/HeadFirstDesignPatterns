namespace TestingDuckBehaviours;

public class Quack : IQuack
{
    void IQuack.Quack()
    {
        Console.WriteLine("quack");
    }
}

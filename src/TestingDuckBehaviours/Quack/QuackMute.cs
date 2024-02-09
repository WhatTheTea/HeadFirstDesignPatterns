namespace TestingDuckBehaviours;

public class QuackMute : IQuack
{
    public void Quack()
    {
        Console.WriteLine("*silence*");
    }

}

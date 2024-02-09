namespace TestingDuckBehaviours;

public abstract class Duck
{
    protected IFly flyBehaviour;
    protected IQuack quackBehaviour;
    public abstract void Display();
    public virtual void Fly() => flyBehaviour.Fly();
    public virtual void Quack() => quackBehaviour.Quack();
    public virtual void Swim() => Console.WriteLine("*splash-splash*");
}
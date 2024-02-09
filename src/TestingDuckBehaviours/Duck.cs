namespace TestingDuckBehaviours;

public abstract class Duck
{
    protected IFly flyBehaviour = new FlyNot();
    protected IQuack quackBehaviour = new QuackMute();
    public abstract void Display();
    public virtual void Fly() =>
        flyBehaviour.Fly();
    public virtual void Quack() => 
        quackBehaviour.Quack();
    // TODO: metal ducks xD
    public virtual void Swim() => 
        Console.WriteLine("*splash-splash*");

    public virtual void SetFlyBehaviour(IFly fly) =>
        flyBehaviour = fly;

    public virtual void SetQuackBehaviour(IQuack quack) =>
        quackBehaviour = quack;
}
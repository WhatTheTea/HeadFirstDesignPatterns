namespace TestingDuckBehaviours;

public abstract class Duck
{
    IFly flyBehaviour;
    IQuack quackBehaviour;
    public abstract void Display();
    public void Fly(){ }
    public void Quack() {}
    public void Swim() {}
}
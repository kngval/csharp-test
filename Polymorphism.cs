class Animal
{
    public virtual void Talk()
    {
        Console.WriteLine("talking...");
    }
}
class Pig : Animal
{
    public override void Talk()
    {
        Console.WriteLine("oink oink");

    }
}

class Duck : Animal
{
    public override void Talk()
    {
        Console.WriteLine("quack quack");

    }
}
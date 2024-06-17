namespace Zootopia;

public class Fish : Animal
{
    private int _numberOfLegs;
    
    public Fish(string category, string name, int age) : base(category, name, age)
    {
    }

    public Fish(int numberOfLegs)
    {
        _numberOfLegs = numberOfLegs;
    }

    public int NumberOfLegs => _numberOfLegs;
    
    public override void Speak()
    {
        Console.WriteLine("The fish goes: blubb blubb");
    }
}
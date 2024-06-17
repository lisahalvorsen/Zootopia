namespace Zootopia;

public class Birds : Animal
{
    private int _numberOfLegs = 2;
    
    public Birds(string category, string name, int age) : base(category, name, age)
    {
        
    }

    public Birds() : base()
    {
    }

    public int NumberOfLegs => _numberOfLegs;

    public override void Speak()
    {
        Console.WriteLine("The bird goes: pip pip");
    }
}
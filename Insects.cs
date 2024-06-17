namespace Zootopia;

public class Insects : Animal
{
    private int _numberOfLegs = 6;
    public Insects(string category, string name, int age) : base(category, name, age)
    {
    }

    public Insects()
    {
        
    }

    public int NumberOfLegs => _numberOfLegs;
    public override void Speak()
    {
        Console.WriteLine("The insects goes: bzzz bzzz");
    }
}
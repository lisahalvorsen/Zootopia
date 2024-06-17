namespace Zootopia;

public class Mammals : Animal
{
    private int _numberOfLegs = 4; 
    
    public Mammals(string category, string name, int age, int numberOfLegs) : base(category, name, age)
    {
    }

    public Mammals()
    {
        
    }

    public int NumberOfLegs => _numberOfLegs;
}
namespace Zootopia;

public class Reptiles : Animal
{
    private int _numberOfLegs = 4;
    
    public Reptiles(string category, string name, int age) : base(category, name, age)
    {
    }

    public Reptiles()
    {
        
    }

    public int NumberOfLegs => _numberOfLegs;
}
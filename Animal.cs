namespace Zootopia;

public class Animal
{
    private string _category { get; } // field with only a getter
    private string _name { get; } // field with only a getter
    private int _age { get; } // field with only a getter

    public Animal(string category, string name, int age) // constructor
    {
        _category = category;
        _name = name;
        _age = age;
    }

    protected Animal()
    {
    }

    public string Category => _category; // property
    public string Name => _name; // property
    public int Age => _age; // property

    public virtual void Speak() // method that can be overridden in child classes
    {
        Console.WriteLine("The animal makes sounds");
    }
}
namespace Zootopia;

public class Zoo
{
    private List<Animal> _allAnimals = new List<Animal>();
    private Mammals mammal = new Mammals();
    private Birds bird = new Birds();
    private Fish fish = new Fish(0);
    private Reptiles reptile = new Reptiles();
    private Insects insect = new Insects();

    public void PrintAllAnimals()
    {
        Console.Clear();
        if (_allAnimals.Count == 0)
        {
            Console.WriteLine("There are no animals in the zoo :(");
            return;
        }
        else
        {
            foreach (var animal in _allAnimals)
            {
                Console.WriteLine($"In the zoo, you can find a(n) {animal.Category}.");
            }
        }
        AnimalMenu();
    }

    public void AnimalMenu()
    {
        Console.WriteLine("Now do you want to ...");
        Console.WriteLine("1. Hear what sounds they make");
        Console.WriteLine("2. See how many legs they have");
        Console.WriteLine("3. Go back to main menu");

        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                HearAnimalSounds();
                break;
            case "2":
                SeeAnimalLegs();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid input, please try again.");
                break;
        }
    }

    public void AddAnimal()
    {
        Console.Clear();
        Console.WriteLine(
            "What kind of animal do you want to add? Categories are: mammals, birds, fish, reptiles and insects.");
        string categoryAnimal = Console.ReadLine();
        Console.WriteLine("What's its name?");
        string nameAnimal = Console.ReadLine();
        Console.WriteLine("How old is it?");
        int ageAnimal = int.Parse(Console.ReadLine());
        Animal newAnimal = new Animal(categoryAnimal, nameAnimal, ageAnimal);
        _allAnimals.Add(newAnimal);
        Console.WriteLine($"{newAnimal.Name} is now in your zoo :D");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void RemoveAnimal()
    {
        Console.Clear();
        if (_allAnimals.Count == 0)
        {
            Console.WriteLine("There are no animals in the zoo to set free.");
        }
        else
        {
            Console.WriteLine("Who do you want to set out in the wild open?");
            string userInput = Console.ReadLine();

            var animalExists = _allAnimals.Any(animal => animal.Name == userInput);
            if (!animalExists)
            {
                Console.WriteLine("The animal you're looking for is not in the zoo.");
                return;
            }

            _allAnimals.RemoveAll(animal => animal.Name == userInput);
            Console.WriteLine($"{userInput} is now living in the wild!");
        }

        Console.ReadKey();
        Console.Clear();
    }

    public void HearAnimalSounds()
    {
        Console.Clear();
        Console.WriteLine(
            "Which animal do you want to hear the sound of? Categories are: birds, fish and insects.");
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "birds":
                bird.Speak();
                break;
            case "fish":
                fish.Speak();
                break;
            case "insects":
                insect.Speak();
                break;
            default:
                Console.WriteLine("Invalid input, please try again.");
                break;
        }
    }

    public void SeeAnimalLegs()
    {
        Console.Clear();
        Console.WriteLine(
            "Which animal do you want to see the legs of? Categories are: mammals, birds, fish, reptiles and insects.");
        string userChoice = Console.ReadLine();

        switch (userChoice) 
        {
            case "mammals":
                Console.WriteLine($"Usually, mammals have {mammal.NumberOfLegs} legs.");
                break;
            case "birds":
                Console.WriteLine($"Birds has {bird.NumberOfLegs} legs.");
                break;
            case "fish":
                Console.WriteLine($"Fish have {fish.NumberOfLegs} legs, they have fins!");
                break;
            case "reptiles":
                Console.WriteLine($"Reptiles have {reptile.NumberOfLegs} legs.");
                break;
            case "insects":
                Console.WriteLine($"Insects have {insect.NumberOfLegs} legs.");
                break;
            default:
                Console.WriteLine("Invalid input, please try again.");
                break;
        }
    }
}
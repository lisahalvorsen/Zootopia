namespace Zootopia;

public class Menu
{
    private Zoo allAnimals = new Zoo();

    public void PrintMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the zoo! What do you want to do today? :)");
            Console.WriteLine("1. See all animals");
            Console.WriteLine("2. Add animals to the zoo");
            Console.WriteLine("3. Remove animals from the zoo");
            Console.WriteLine("4. Leave the zoo");

            string userChoice = Console.ReadLine();
            
            switch (userChoice)
            {
                case "1":
                    allAnimals.PrintAllAnimals();
                    break;
                case "2":
                    allAnimals.AddAnimal();
                    break;
                case "3":
                    allAnimals.RemoveAnimal();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    break;
            }
        }
    }
}
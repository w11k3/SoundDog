// Parent class (superclass)
public class Animal
{
    // Fields (attributes)
    public string species;

    // Constructor
    public Animal(string species)
    {
        this.species = species;
    }

    // Method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Child class (subclass) inheriting from Animal
public class Dog : Animal
{
    // Additional field (attribute)
    private string name;

    // Constructor using base keyword to call superclass constructor
    public Dog(string name) : base("Dog")
    {
        this.name = name;
    }

    // Method overriding the MakeSound method in Animal
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    // Additional method specific to Dog
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Dog class
        Dog myDog = new Dog("Buddy");

        // Accessing inherited fields and methods
        Console.WriteLine($"Species: {myDog.species}"); // Outputs: Dog
        myDog.MakeSound(); // Outputs: Woof!

        // Calling subclass-specific method
        myDog.Bark(); // Outputs: Barking...
    }
}
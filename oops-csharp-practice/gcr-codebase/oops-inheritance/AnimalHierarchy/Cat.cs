using System; // Importing System namespace for Console

// Cat class inherits from Animal
// 'class' is internal by default in C#, so it's accessible within the same assembly
class Cat : Animal
{
    // 'public' allows this method to be accessed wherever Cat objects are used
    // 'override' is used to provide specific implementation for Cat
    public override void MakeSound()
    {
        // Print Cat-specific sound
        Console.WriteLine("Cat meows");
    }
}
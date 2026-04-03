using System; // Importing System namespace for Console

// Bird class inherits from Animal
// 'class' is internal by default in C#, so it's accessible within the same assembly
class Bird : Animal
{
    // 'public' allows this method to be accessed wherever Bird objects are used
    // 'override' is used to provide specific implementation for Bird
    public override void MakeSound()
    {
        // Print Bird-specific sound
        Console.WriteLine("Bird chirps");
    }
}
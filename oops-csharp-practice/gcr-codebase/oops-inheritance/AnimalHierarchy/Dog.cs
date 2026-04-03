using System; // Importing System namespace for Console

// Dog class inherits from Animal
// 'class' is internal by default in C#, so it's accessible within the same assembly
class Dog : Animal
{
    // 'public' allows this method to be accessed wherever Dog objects are used
    // 'override' is used to provide specific implementation for Dog
    public override void MakeSound()
    {
        // Print Dog-specific sound
        Console.WriteLine("Dog barks");
    }
}
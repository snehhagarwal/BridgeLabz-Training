using System; // Importing System namespace for Console

// Base Animal class for inheritance
// 'class' is internal by default in C#, so it's accessible within the same assembly
class Animal
{
    // 'public' allows these fields to be accessed from derived classes and other classes
    public string Name;
    public int Age;

    // 'public' allows this method to be called from outside the class
    // 'virtual' allows derived classes to override this method for specific behavior
    public virtual void MakeSound()
    {
        // Print generic animal sound
        Console.WriteLine("Animal makes sound");
    }
}
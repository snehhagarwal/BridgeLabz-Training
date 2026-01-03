using System;

// Program demonstrating polymorphism with Animal inheritance
class Program
{
    static void Main(string[] args)
    {
        // Create array of different animals
        Animal[] arr = new Animal[3];
        arr[0]=new Dog();
        arr[1]=new Cat();
        arr[2]=new Bird();

        // Loop through and make each animal sound
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].MakeSound();
        }
    }

}
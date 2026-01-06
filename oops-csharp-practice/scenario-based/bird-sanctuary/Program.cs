using System;

class Program
{
    static void Main(string[] args)
    {
        Bird[] arr=new Bird[5];  // Array to store birds

        arr[0]=new Eagle{"Eagle","Brown"};  // Eagle object
        arr[1]=new Sparrow{"Sparrow","Grey"};  // Sparrow object
        arr[2]=new Duck{"Duck","White"};       // Duck object
        arr[3]=new Penguin{"Penguin","Black"};  // Penguin object
        arr[4]=new Seagull{"Seagull","White"};  // Seagull object

        int choice;   // Store user choice

        do
        {
            Console.WriteLine("Bird Sanctuary");
            Console.WriteLine("1. Display all birds");
            Console.WriteLine("2. Make Flying Birds Fly");
            Console.WriteLine("3. Make swimming Birds swim");
            Console.WriteLine("4. Exit");

            choice=Convert.ToInt32(Console.ReadLine());  // Read choice

            switch (choice)
            {
                case 1:
                   for(int i = 0; i < arr.Length; i++)  // Loop through birds
                    {
                        // Display bird details
                        arr[i].Display();
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for(int i = 0; i < arr.Length; i++)
                    {
                        // Check flying birds
                        if(arr[i] is ISwimmable)
                        {
                            // Call Fly method
                            (IFlyable)arr[i].Fly();
                        }
                    }
                    break;
                case 3:
                    for(int i = 0; i < arr.Length; i++)
                    {
                        // Check swimming birds
                        if(arr[i] is ISwimmable)
                        {
                            // Call Swim method
                            ((ISwimmable)arr[i]).Swim();
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you");   // Exit message
                    break;
                default:
                    Console.WriteLine("Invalid choice");  // Wrong input
                    break;                
            }
        }while(choice!=4);
    }
}
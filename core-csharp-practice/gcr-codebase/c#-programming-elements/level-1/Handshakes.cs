using System;

class Handshakes{
    static void Main(){
        //taking as input
        Console.WriteLine("Enter no of students: ");

        int n=Convert.ToInt32(Console.ReadLine());

        //calculating the handshakes
        int handshake=(n*(n-1))/2;

        Console.WriteLine("Maximum number of handshakes is " + handshake);


    }
}
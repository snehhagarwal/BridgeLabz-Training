using System;

class TwoDIntoOneD{
    static void Main(string[] args){

        //taking row and column from the user 
        Console.Write("Enter the rows: ");
        int row=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the column: ");
        int column=Convert.ToInt32(Console.ReadLine());

        int[,] arr=new int[row,column];
        int[] array=new int[row*column];
        int idx=0;

        //taking elements in 2D as input  and storing in 1D
        for(int i=0;i<row;i++){
            for(int j=0;j<column;j++){
                Console.Write("Enter the element: ");
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
                array[idx++]=arr[i,j];
            }
        }
        
        //printing array
        Console.WriteLine("1D Array: ");
        for(int i=0;i<array.Length;i++){
            Console.Write(arr[i] + " ");
        }

    }
}
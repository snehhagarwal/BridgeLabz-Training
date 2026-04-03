using System;

class MatrixManipulation
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the row: ");
        int row=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the column: ");
        int col=Convert.ToInt32(Console.ReadLine());
        int[,] A=Create(row,col);

        Console.WriteLine("Matrix A: ");
        Display(A);

        int[,] trans = Transpose(A);
        Console.WriteLine("Transpose of A: ");
        Display(trans);

        if(row==2 && col == 2)
        {
            Console.WriteLine("Determinant: " + Determinant(A));
        }
    }

    static int[,] Create(int r,int c)
    {
        Random r=new Random();
        int[,] mat=new int[r,c];
        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                mat[i,j]=r.Next(1,10);
            }
        }
        return mat;
    }
    static int[,] Transpose(int[,] A)
    {
        int r=A.GetLength(0);
        int c=A.GetLength(1);
        int[,] res=new int[c,r];
        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                res[j,i]=A[i,j];
            }
        }
        return res;
    }

    static int Determinant(int[,] m)
    {
        int ans=(m[0,0]*m[1,1])-(m[0,1]*m[1,0]);
        return ans;
    }

    static void Display(int[,] m)
    {
        for(int i = 0; i < m.Length; i++)
        {
            for(int j = 0; j < m.Length; j++)
            {
                Console.Write(m[i,j]+"  ");
            }
            Console.WriteLine();
        }
    }
}
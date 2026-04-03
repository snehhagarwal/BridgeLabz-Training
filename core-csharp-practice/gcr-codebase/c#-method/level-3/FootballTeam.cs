using System;

class FootballTeam
{
    static void Main(string[] args)
    {
        int[] height=new int[11];
        Random r=new Random();

        //generating random numbers
        for(int i = 0; i < height.Length; i++)
        {
            height[i]=r.Next(150,251);
        }

        Console.WriteLine("Shortest: " + Shortest(height));
        Console.WriteLine("Tallest: " + Tallest(height));
        Console.WriteLine("Mean: " + (double)Sum(height)/height.Length);
    }

    //sum for mean 
    static int Sum(int[] n)
    {
        int sum=0;
        for(int i = 0; i < n.Length; i++)
        {
            sum+=n[i];
        }
        return sum;
    }

    //shortest height 
    static int Shortest(int[] n)
    {
        int min=n[0];
        for(int i = 1; i < n.Length; i++)
        {
            if (n[i] < min)
            {
                min=n[i];
            }
        }
        return min;
    }

    //tallest height 
    static int Tallest(int[] n)
    {
        int max=n[0];
        for(int i = 1; i < n.Length; i++)
        {
            if (n[i] > max)
            {
                max=n[i];
            }
        }       
        return max;
    }
}

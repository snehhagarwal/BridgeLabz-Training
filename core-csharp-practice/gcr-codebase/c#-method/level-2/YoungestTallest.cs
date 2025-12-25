using System;

class YoungestTallest
{
    static void Main(string[] args)
    {
        string[] name={"Amar","Akbar","Anthony"};
        int[] age=new int[3];
        double[] height=new int[3];

        //taking input from the user
        for(int i = 0; i < 3; i++)
        {
            Console.Write("Enter the age:");
            age[i]=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height: ");
            height[i]=Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Youngest: " + name[youngest(age)]);
        Console.WriteLine("Tallest: " + name[tallest(height)]);
    }

    static int youngest(int[] age)
    {
        int  min=age[0];
        int idx=0;
        for(int i = 0; i < 3; i++)
        {
            if (age[i] < min)
            {
                min=age[i];
                idx=i;
            }
        }
        return idx;
    }

    static int tallest(double[] height)
    {
        double max=height[0];
        int idx=0;
        for(int i = 1; i < 3; i++)
        {
            if (height[i] > max)
            {
                max=height[i];
                idx=i;
            }
        }
        return idx;
    }
}
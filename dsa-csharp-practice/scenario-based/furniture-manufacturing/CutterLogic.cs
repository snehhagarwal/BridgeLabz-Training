using System;

public class CutterLogic
{
    public int MaxRevenue(WoodenRod rod,PriceTable table)
    {
        int[] revenue=new int[rod.Length+1];

        for(int i = 1; i <= rod.Length; i++)
        {
            int max=table.GetPrice(i);

            for(int j = 1; j < i; j++)
            {
                int value=revenue[j]+revenue[i-j];
                if (value > max)
                {
                    max=value;
                }
            }

            revenue[i]=max;
        }
        return revenue[rod.Length];
    }

    public int MaxWithWaste(WoodenRod rod,PriceTable table,int maxWaste)
    {
        int best=0;

        for(int used = rod.Length; used >= rod.Length - maxWaste; used--)
        {
            int[] revenue=new int[used+1];

            for(int i = 1; i <= used; i++)
            {
                int max=table.GetPrice(i);

                for(int j = 1; j < i; j++)
                {
                    int value=revenue[j]+revenue[i-j];
                    if (value > max)
                    {
                        max=value;
                    }
                }

                revenue[i]=max;
            }

            if (revenue[used] > best)
            {
                best=revenue[used];
            }

        }
        return best;
    }

    public void Suggest(WoodenRod rod,PriceTable table)
    {
        int[] revenue=new int[rod.Length+1];
        int[] cut=new int[rod.Length+1];

        for(int i = 1; i <= rod.Length; i++)
        {
            revenue[i]=table.GetPrice(i);
            cut[i]=i;

            for(int j = 1; j < i; j++)
            {
                int value=revenue[j] + revenue[i-j];
                if (value > revenue[i])
                {
                    revenue[i]=value;
                    cut[i]=j;
                }
            }
        }

        Console.WriteLine("Suggested cuts: ");
        int remaining=rod.Length;

        while (remaining > 0)
        {
            Console.Write(cut[remaining] + "ft");
            remaining-=cut[remaining];
        }
    }

    
}
using System;

class MergeSort
{
    // Merge two sorted halves
    static void Merge(int[] arr,int l,int m,int r)
    {
        int n1=m-l+1;
        int n2=r-m;

        int[] L=new int[n1];
        int[] R=new int[n2];

        for(int i = 0; i < n1; i++)
        {
            L[i]=arr[l+i];
        }

        for(int j = 0; j < n2; j++)
        {
            R[j]=arr[m+1+j];
        }

        int iIdx=0;
        int jIdx=0;
        int k=1;

        while(iIdx<n1 && jIdx < n2)
        {
            if (L[iIdx] <= R[jIdx])
            {
                arr[k++]=L[iIdx++];
            }
            else
            {
                arr[k++]=R[jIdx++];
            }
        }

        while (iIdx < n1)
        {
            arr[k++]=L[iIdx++];
        }

        while (jIdx < n2)
        {
            arr[k++]=R[jIdx++];
        }
    }
    // Recursive merge sort function
    static void Sort(int[] arr,int l,int m,int r)
    {
        if (l < r)
        {
            int m=(l+r)/2;
            Merge(arr,l,m);
            Merge(arr,m+1,r);
            Merge(arr,l,m,r);
        }
    }
    // Program entry point method
    static void Main(string[] args)
    {
        Console.Write("Enter number of books: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] prices=new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter price: ");
            prices[i]=Convert.ToInt32(Console.ReadLine());
        }

        Sort(prices,0,n-1);

        Console.WriteLine("Sorted Book Prices: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }
}
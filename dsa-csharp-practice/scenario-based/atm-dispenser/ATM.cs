using System;
class ATM
{
    //encapsulated fields 
    protected int[] denominations;
    protected int[] noteCount;

    //parameterized constructor
    public ATM(int[] denoms)
    {
        denominations=denoms;
        noteCount=new int[denoms.Length];
    }

    //for polymorphism
    public virtual void Dispense(int amnt)
    {
        int remaining=amnt;

        for(int i = 0; i < denominations.Length; i++)
        {
            noteCount[i]=remaining/denominations[i];
            remaining=remaining%denominations[i];
        }

        if (remaining != 0)
        {
            Console.WriteLine("Exact change is not possible");
            Console.WriteLine("Remaining amount: Rs. " + remaining);
            return;
        }

        Console.WriteLine("Amount Dispensed: " + amnt);

        //displaying notes
        for(int i = 0; i < denominations.Length; i++)
        {
            if (noteCount[i] > 0)
            {
                Console.WriteLine("Rs. " + denominations[i] + " x " + noteCount[i]);
            }
        }
    }


}
using System;

public class InPatient : Patient
{
    public int Days{get;set;}

    public override double CalculateBill()
    {
        return Days*2000;
    }
}
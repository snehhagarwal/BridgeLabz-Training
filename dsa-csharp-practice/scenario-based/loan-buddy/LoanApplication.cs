using System;

class LoanApplication
{
    public string LoanType;
    public int Term;
    public double InterestRate;

    public double[] rateHistory=new double[1];

    public LoanApplication(string type,int term,double rate)
    {
        LoanType=type;
        Term=term;
        InterestRate=rate;
        rateHistory[0]=rate;
    }
}
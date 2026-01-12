using System;

public class Applicant
{
    private int creditScore;
    public string Name;
    public double Income;
    public double LoanAmount;

    private int[] creditHistory=new int[1];

    public Applicant(string name,int score,double income,double loanAmount)
    {
        Name=name;
        creditScore=score;
        Income=income;
        LoanAmount=loanAmount;

        creditHistory[0]=score;
    }

    public int Get()
    {
        return creditScore;
    }
}

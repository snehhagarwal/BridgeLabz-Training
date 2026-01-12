using System;

class Loan : IApprovable
{
    protected Applicant applicant;
    protected LoanApplication application;

    protected bool isApproved;

    protected string[] status=new string[1];

    public Loan(Applicant applicant,LoanApplication application)
    {
        this.applicant=applicant;
        this.application=application;
        status[0]="CREATED";
    }

    public virtual bool ApproveLoan()
    {
        if(applicant.Get()>=650 && applicant.Income > 20000)
        {
            isApproved=true;
            status[0]="APPROVED";
        }
        else
        {
            isApproved=false;
            status[0]="REJECTED";
        }
        return isApproved;
    }

    public virtual double CalculateEMI()
    {
        double P=applicant.LoanAmount;
        double R=application.InterestRate/(12*100);
        int N=application.Term;

        return (P * R * System.Math.Pow(1 + R, N))/(System.Math.Pow(1 + R, N) - 1);
    }
}
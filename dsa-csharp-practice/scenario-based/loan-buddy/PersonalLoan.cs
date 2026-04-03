using System;

public class PersonalLoan : Loan
{
    private double[] extra=new double[1];

    public PersonalLoan(Applicant applicant,LoanApplication application)
    {
        this.applicant=applicant;
        this.application=application;
        extra[0]=500;
    }

    public PersonalLoan() : base(null,null)
    {}

    public override double CalculateEMI()
    {
        double emi=base.CalculateEMI();
        return emi+extra[0];
    }
}
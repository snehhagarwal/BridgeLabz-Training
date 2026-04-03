using System;
public class HomeLoan : Loan
{
    // Array used
    private double[] subsidy = new double[1];

    public HomeLoan(Applicant applicant, LoanApplication application)
        : this()
    {
        this.applicant = applicant;
        this.application = application;
        subsidy[0] = 0.9;
    }

    public HomeLoan()
        : base(null, null)
    {
    }

    public override double CalculateEMI()
    {
        return base.CalculateEMI() * subsidy[0];
    }
}


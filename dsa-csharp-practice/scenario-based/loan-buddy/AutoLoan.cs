
public class AutoLoan : Loan
{
    // Array used
    private double[] insuranceFee = new double[1];

    public AutoLoan(Applicant applicant, LoanApplication application)
        : this()
    {
        this.applicant = applicant;
        this.application = application;
        insuranceFee[0] = 300;
    }

    public AutoLoan()
        : base(null, null)
    {
    }

    public override bool ApproveLoan()
    {
        if (applicant.GetCreditScore() >= 600)
        {
            isApproved = true;
            statusLog[0] = "APPROVED_AUTO";
        }
        else
        {
            isApproved = false;
            statusLog[0] = "REJECTED_AUTO";
        }
        return isApproved;
    }
}
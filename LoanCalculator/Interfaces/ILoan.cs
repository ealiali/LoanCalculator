namespace LoanCalculator.Interfaces
{
    public interface ILoan
    {
        decimal CalculateInterestFee(int loanDurationMonths, decimal loanAmount, decimal interestRate, decimal limit = 0.00M);
    }
}

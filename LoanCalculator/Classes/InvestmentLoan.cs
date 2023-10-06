using LoanCalculator.Interfaces;

namespace LoanCalculator.Classes
{
    public class InvestmentLoan : IInvestmentLoan
    {
        public decimal CalculateInterestFee(int loanDurationMonths, decimal loanAmount, decimal interestRate, decimal limit)
        {
            decimal monthlyInterestRate = interestRate / 12 / 100;
            decimal totalInterest = 0;
            for (int i = 0; i < loanDurationMonths; i++)
            {
                decimal monthlyInterest = loanAmount * monthlyInterestRate;
                totalInterest += monthlyInterest;
            }

            return totalInterest;
        }
    }
}

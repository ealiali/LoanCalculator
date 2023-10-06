using LoanCalculator.Interfaces;

namespace LoanCalculator.Classes
{
    public class PersonalLoan : IPersonalLoan
    {
        public decimal CalculateInterestFee(int loanDurationMonths, decimal loanAmount, decimal interestRate, decimal limit)
        {
            decimal totalInterest = 0;
            int loanDurationInYear = loanDurationMonths / 12;
            for (int i = 0; i < loanDurationInYear; i++)
            {
                decimal yearlyInterest = loanAmount * interestRate / 100;
                totalInterest += yearlyInterest;
            }

            return totalInterest;
        }
    }
}

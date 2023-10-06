using LoanCalculator.Interfaces;

namespace LoanCalculator.Classes
{
    public class CarLoan : ICarLoan
    {
        public CarLoan()
        {
        }

        public decimal CalculateInterestFee(int loanDurationMonths, decimal loanAmount, decimal interestRate, decimal limit)
        {
            decimal totalInterest = 0;
            int loanDurationInYear = loanDurationMonths / 12;
            for (int i = 0; i < loanDurationInYear; i++)
            {
                decimal yearlyInterest = loanAmount * interestRate / 100;
                totalInterest += yearlyInterest;
                if(totalInterest > limit)
                {
                    totalInterest = limit;
                    break;
                }
            }

            return totalInterest;
        }
    }
}

using LoanCalculator.Dto;
using LoanCalculator.Models;

namespace LoanCalculator.Interfaces
{
    public interface ILoanService
    {
        decimal CalculateInterestFeeOfLoan(LoanCalculatorInputDto input);
    }
}

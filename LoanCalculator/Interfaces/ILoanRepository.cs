using LoanCalculator.Models;

namespace LoanCalculator.Interfaces
{
    public interface ILoanRepository
    {
        IList<Loan> GetLoans();
        Loan GetLoanByID(int loanID);
        Loan GetLoanByType(LoanType type);
    }
}

using LoanCalculator.Data;
using LoanCalculator.Interfaces;
using LoanCalculator.Models;

namespace LoanCalculator.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LoanDBContext _loanDBContext;
        public LoanRepository(LoanDBContext loanDBContext)
        {
            _loanDBContext = loanDBContext;
        }
        //should moved to repository 
        public IList<Loan> GetLoans()
        {
            return _loanDBContext.Loans.ToList();
        }
        public Loan GetLoanByID(int loanID)
        {
            return _loanDBContext.Loans.FirstOrDefault(x => x.LoanId == loanID);
        }
        public Loan GetLoanByType(LoanType type)
        {
            return _loanDBContext.Loans.FirstOrDefault(x => x.LoanType == type);
        }
    }
}


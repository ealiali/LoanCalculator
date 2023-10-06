using LoanCalculator.Classes;
using LoanCalculator.Data;
using LoanCalculator.Dto;
using LoanCalculator.Interfaces;
using LoanCalculator.Models;

namespace LoanCalculator.Services
{
    public class LoanService : ILoanService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository, IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this._loanRepository = loanRepository;
        }
        private ILoan GetLoanByType(LoanType loanType)
        {
            // Use the dependency injection container to resolve the specific loan type
            // based on the loanType query parameter
            switch (loanType)
            {
                case LoanType.Car:
                    return serviceProvider.GetRequiredService<ICarLoan>();
                case LoanType.Personal:                    
                    return serviceProvider.GetRequiredService<IPersonalLoan>();
                case LoanType.Investment:
                    return serviceProvider.GetRequiredService<IInvestmentLoan>();
                // Add cases for other loan types
                default:
                    throw new ArgumentException("Invalid loan type");
            }
        }
        public decimal CalculateInterestFeeOfLoan(LoanCalculatorInputDto input)
        {
            try
            {
                ILoan loan = GetLoanByType(input.LoanType);
                var loanObject = _loanRepository.GetLoanByType(input.LoanType);
                if (loanObject == null)
                    throw new ArgumentException("No loan founded for the loan Id");
                else
                    return loan.CalculateInterestFee(input.LoanDurationMonths, input.LoanAmount, loanObject.InterestRate, loanObject.Limit);
            }
            catch(Exception ex) {
                throw;
            }
        }
    }
}

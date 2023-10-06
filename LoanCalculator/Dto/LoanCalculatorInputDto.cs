using LoanCalculator.Models;

namespace LoanCalculator.Dto
{
    public class LoanCalculatorInputDto
    {
        public int LoanDurationMonths { get; set; }
        public decimal LoanAmount { get; set; }
        public LoanType LoanType { get; set; }
    }
}

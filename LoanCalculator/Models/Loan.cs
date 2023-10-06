using System.ComponentModel.DataAnnotations;

namespace LoanCalculator.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Limit { get; set; }
        public LoanType LoanType { get; set; }
    }
    public enum LoanType
    {
        Personal,
        Investment,
        Car
    }
}

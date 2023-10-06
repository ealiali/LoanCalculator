using LoanCalculator.Dto;
using LoanCalculator.Interfaces;
using LoanCalculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;
        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }
        [HttpPost("calculate-interest")]
        public IActionResult CalculateInterest(LoanCalculatorInputDto input)
        {
            try
            {
                // Use the loan factory to create the specific loan object
                decimal interestFee = _loanService.CalculateInterestFeeOfLoan(input);

                return Ok($"Interest Fee: {interestFee}");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

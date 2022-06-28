using System;
using Xunit;
using tax_calculator_infrastructure.Repositories;

namespace tax_calculator_tests
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void TaxCalculator_Returns()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 6, 30, 0),
                new DateTime(2013, 1, 10, 7, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Car", dates);

            Assert.Equal(18, result);
        }
    }
}

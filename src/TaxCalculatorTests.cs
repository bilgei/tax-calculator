using System;
using Xunit;

namespace tax_calculator
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

            var calculator = new CongestionTaxCalculator();
            var result = calculator.GetTax(new Car(), dates);

            Assert.Equal(18, result);
        }
    }
}

using System;
using Xunit;
using tax_calculator_infrastructure.Repositories;

namespace tax_calculator_tests
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void TaxCalculator_Car3Passes_ReturnsTotalOf2HighestAmount()
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

        [Fact]
        public void TaxCalculator_Car9Passes_Returns60InsteadOf107()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 30, 0), //13
                new DateTime(2013, 1, 10, 7, 40, 0), //18
                new DateTime(2013, 1, 10, 9, 0, 0), //8
                new DateTime(2013, 1, 10, 11, 0, 0), //8
                new DateTime(2013, 1, 10, 13, 0, 0), //8
                new DateTime(2013, 1, 10, 15, 0, 0), //13
                new DateTime(2013, 1, 10, 16, 10, 0), //18
                new DateTime(2013, 1, 10, 17, 20, 0), //13
                new DateTime(2013, 1, 10, 18, 25, 0) //8
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Car", dates);

            Assert.Equal(60, result);
        }

        [Fact]
        public void TaxCalculator_Bus_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 17, 30, 0),
                new DateTime(2013, 1, 10, 21, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Bus", dates);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaxCalculator_Motorcycle_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 17, 30, 0),
                new DateTime(2013, 1, 10, 21, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Motorcycle", dates);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaxCalculator_Emergency_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 17, 30, 0),
                new DateTime(2013, 1, 10, 21, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Emergency", dates);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaxCalculator_Diplomat_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 17, 30, 0),
                new DateTime(2013, 1, 10, 21, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Diplomat", dates);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaxCalculator_Foreign_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 17, 30, 0),
                new DateTime(2013, 1, 10, 21, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Foreign", dates);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaxCalculator_Military_3Passes_Returns0()
        {
            var dates = new[] {
                new DateTime(2013, 1, 10, 6, 0, 0),
                new DateTime(2013, 1, 10, 9, 30, 0),
                new DateTime(2013, 1, 10, 11, 0, 0)
            };

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTax("Military", dates);

            Assert.Equal(0, result);
        }
    }
}

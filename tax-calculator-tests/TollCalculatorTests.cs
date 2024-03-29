﻿using System;
using Xunit;
using tax_calculator_infrastructure.Repositories;

namespace tax_calculator_tests
{
    public class TollCalculatorTests
    {
        [Fact]
        public void CarTollFee_At6_Returns8()
        {
            var expectedTollFee = 8;
            var date = new DateTime(2013, 1, 10, 6, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At630_Returns13()
        {
            var expectedTollFee = 13;
            var date = new DateTime(2013, 1, 10, 6, 30, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At7_Returns18()
        {
            var expectedTollFee = 18;
            var date = new DateTime(2013, 1, 10, 7, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At8_Returns13()
        {
            var expectedTollFee = 13;
            var date = new DateTime(2013, 1, 10, 8, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At12_Returns8()
        {
            var expectedTollFee = 8;
            var date = new DateTime(2013, 1, 10, 12, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At15_Returns13()
        {
            var expectedTollFee = 13;
            var date = new DateTime(2013, 1, 10, 15, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At16_Returns18()
        {
            var expectedTollFee = 18;
            var date = new DateTime(2013, 1, 10, 16, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At17_Returns13()
        {
            var expectedTollFee = 13;
            var date = new DateTime(2013, 1, 10, 17, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At18_Returns8()
        {
            var expectedTollFee = 8;
            var date = new DateTime(2013, 1, 10, 18, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void CarTollFee_At19_Returns0()
        {
            var expectedTollFee = 0;
            var date = new DateTime(2013, 1, 10, 19, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Car", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }

        [Fact]
        public void BusTollFee_At9_Returns0()
        {
            var expectedTollFee = 0;
            var date = new DateTime(2013, 1, 10, 9, 0, 0);

            var taxCalculatorRepository = new TaxCalculatorRepository();
            var result = taxCalculatorRepository.GetTollFee("Bus", date);

            Assert.Equal(expected: expectedTollFee, actual: result);
        }
    }
}

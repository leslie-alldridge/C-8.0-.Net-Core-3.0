using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void PrimeFactors4()
        {
            int number = 4;
            string expected = "2 2 ";
            
            var PrimeFactors = new PrimeFactors();

            string actual = PrimeFactors.CalculatePrimeFactors(number);

            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void PrimeFactors7()
        {
            int number = 7;
            string expected = "7 ";
            
            var PrimeFactors = new PrimeFactors();

            string actual = PrimeFactors.CalculatePrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactors30()
        {
            int number = 30;
            string expected = "2 3 5 ";
            
            var PrimeFactors = new PrimeFactors();

            string actual = PrimeFactors.CalculatePrimeFactors(number);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PrimeFactors40()
        {
            int number = 40;
            string expected = "2 2 2 5 ";
            
            var PrimeFactors = new PrimeFactors();

            string actual = PrimeFactors.CalculatePrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactors50()
        {
            int number = 50;
            string expected = "2 5 5 ";
            
            var PrimeFactors = new PrimeFactors();

            string actual = PrimeFactors.CalculatePrimeFactors(number);

            Assert.Equal(expected, actual);
        }
    }
}

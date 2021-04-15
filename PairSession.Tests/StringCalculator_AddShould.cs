using System;
using Xunit;

namespace PairSession.Tests
{
    public class StringCalculator_AddShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void should_return_sum_of_zero(int expected, string input)
        {
            int result = calculator.Add(input);

            Assert.Equal(expected, result);
        }

      
    }
}

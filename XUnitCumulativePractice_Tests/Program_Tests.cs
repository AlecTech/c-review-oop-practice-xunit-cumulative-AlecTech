using System;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests
    {

        /*
         * Test Data Is:   Test Data Is:  	   Test Data Is:    Assertion:
           An Integer	   Between 1 and 100    Even Number     ValidateOneToOneHundredEven()     
                                                                Returns:
	        false	        false	            false	        false
            true	        false	            true	        false
            true	        false	            false	        false
            true	        true	            false	        false
            true	        true	            true	        true
         * 
         *  Don’t forget to include edge cases (right on the border of acceptable, 
         *  example if we wanted between 1 and 5, we would test at least -1, 0, 1, 5 and 6).
            Please include at least 3 sets of test data per row.
         * 
         */

        [Theory]
        [InlineData("a", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]

        public void ValidateOneToOneHundredEven_TestIfInt(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }


        [Theory]
        [InlineData("-2", false)]
        [InlineData("101", false)]
        [InlineData("0", false)]

        public void ValidateOneToOneHundredEven_TestInsideRange(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("1001", false)]
        [InlineData("171", false)]
        [InlineData("-1", false)]

        public void ValidateOneToOneHundredEven_TestIfEven(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }


        [Theory]
        [InlineData("11", false)]
        [InlineData("1", false)]
        [InlineData("99", false)]

        public void ValidateOneToOneHundredEven_TestShouldReturnFalseWhenTestIntButOdd(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }


        [Theory]
        [InlineData("6", true)]
        [InlineData("50", true)]
        [InlineData("100", true)]

        public void ValidateOneToOneHundredEven_TestShouldReturnTrue(string input, bool expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            bool output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.ValidateOneToOneHundredEven(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }
    }
}

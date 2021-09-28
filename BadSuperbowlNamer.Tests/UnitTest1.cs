using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    //test classes must be public
    public class NumberToRomanNumeralTests
    {
        //need to have fact attribute, and needs to be public
        [Fact]
        public void the_number_1_is_translated_into_the_letter_I()
        {
            //Arrange -> context that the test is run inside of
            var numberToTranslate = 1;
            var expectedResult = "I";
            var translator = new NumberTranslator();

            //Act -> the actual thing we're testing, do the thing
            var actualResult = translator.Translate(numberToTranslate);

            //Assert -> lay out the expectations in such a way that, if not met, exceptions are thrown.
            //if (actualResult != expectedResult){
            //    throw new Exception($"This is wrong. {actualResult} is not equal to {expectedResult}");
            //}

            //Assert.True(actualResult == expectedResult); //does above if() logic for free
            Assert.Equal(expectedResult, actualResult); //a better test


            //tests pass if no exceptions are thrown while the test is running
            //tests fail if any exceptions are thrown while the test is running:
                //throw new Exception("This test is bad and should feel bad.");
        }

        [Fact]
        public void the_number_4_should_be_translated_to_IV()
        {
            //Arrange
            var numberToTranslate = 4;
            var expectedResult = "IV";
            var translator = new NumberTranslator();

            //Act
            var actualResults = translator.Translate(numberToTranslate);

            //Assert
            Assert.Equal(expectedResult, actualResults);

        }

        [Fact]
        public void the_number_3_should_be_translated_to_III()
        {
            //Arrange
            var numberToTranslate = 3;
            var expectedResult = "III";
            var translator = new NumberTranslator();

            //Act
            var actualResults = translator.Translate(numberToTranslate);

            //Assert
            Assert.Equal(expectedResult, actualResults);
        }

        [Theory] //more a statement of proofs, not a fact
        [InlineData(1,"I")] //says you will provide values for arguments
        [InlineData(2,"II")]
        [InlineData(3,"III")] //each inlinedata creates new execution of following test
        [InlineData(4,"IV")]
        [InlineData(5,"V")]
        [InlineData(8,"VIII")]
        [InlineData(9,"IX")]
        [InlineData(10,"X"), InlineData(14,"XIV"), InlineData(15,"XV"), InlineData(19,"XIX"), InlineData(24,"XXIV")] // can comma separate to save space
        [InlineData(29,"XXIX")]
        [InlineData(39,"XXXIX")]
        [InlineData(45,"XL")]
        // can also create lists to cycle through with InlineData
        // can also use database to store tests
        public void given_a_number_it_is_translated_appropriately(int numberToTranslate, string expectedResult)
        {
            //Arrange
            var translator = new NumberTranslator();

            //Act
            var actualResults = translator.Translate(numberToTranslate);

            //Assert
            Assert.Equal(expectedResult, actualResults);
        }


    }
}

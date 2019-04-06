using System;
using Xunit;

namespace Number.Tests
{
    public class NumberToRomanConvertorTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XX", 20)]
        [InlineData("LVIII", 58)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("CMXCVIII", 998)]
        [InlineData("M", 1000)]
        [InlineData("MMMCMXCIX", 3999)]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanString(string expected, int value)
        {
            // Arrange
            NumberToRomanConvertor roman = new NumberToRomanConvertor();
            //Act
            string actual = roman.NumberToRoman(value);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Arabic_WhenCantConvertValue_ShouldRiseAnException()
        {
            // Arrange
            NumberToRomanConvertor roman = new NumberToRomanConvertor();
            //Act
            Action actual = () => roman.NumberToRoman(-1);
            //Assert
            Assert.Throws<ArgumentException>(actual);
        }
    }
}
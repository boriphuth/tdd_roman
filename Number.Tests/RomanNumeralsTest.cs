using System;
using Xunit;

namespace Number.Tests
{
    public class RomanNumeralsTest
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
        [InlineData("(X)", 10000)]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanString(string expected, int value)
        {
            // Arrange
            RomanNumerals roman = new RomanNumerals();
            //Act
            string actual = roman.ToRoman(value);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanStringOver4000()
        {
            // Arrange
            RomanNumerals roman = new RomanNumerals();
            //Act
            string actual = roman.ToRoman(4000);
            //Assert
            var expected = "(IV)";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Arabic_WhenCantConvertValue_ShouldRiseAnException()
        {
            // Arrange
            RomanNumerals roman = new RomanNumerals();
            //Act
            Action actual = () => roman.ToRoman(-1);
            //Assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(20, "XX")]
        [InlineData(58, "LVIII")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(998, "CMXCVIII")]
        [InlineData(1000, "M")]
        [InlineData(10000, "(X)")]
        public void Roman_WhenConvertIntegerValue_ShouldReturnArabic(int expected, string value)
        {
            // Arrange
            RomanNumerals roman = new RomanNumerals();
            //Act
            int actual = roman.ToArabic(value);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
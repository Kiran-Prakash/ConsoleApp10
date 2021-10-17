using ConsoleApp10;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class PasswordTests
    {
        [Fact]
        public void validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(8)+'A';
            var validationResult = testTarget.Validate(password);
            Assert.True(validationResult);
        }

        [Fact]
        public void validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(6)+'a';
            var validationResult = testTarget.Validate(password);
            Assert.False(validationResult);
        }

        [Fact]
        public void validate_GivenNoUpperCase_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(8); //no uppercase letters
            var validationResult = testTarget.Validate(password);
            Assert.False(validationResult);
        }

        [Fact]
        public void validate_GivenOneUpperCase_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(7)+'A'; //one uppercase letters
            var validationResult = testTarget.Validate(password);
            Assert.True(validationResult);
        }

        private string MakeString(int length)
        {
            string resultString = "";
            for (int i = 1; i <= length; i++)
            {
                resultString += 'a';
            }
            return resultString;
        }
    }
}

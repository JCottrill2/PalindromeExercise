using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("tacocat", true)]
        [InlineData("canoe", false)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var instance = new WordSmith();

            //act
            var actual = instance.IsAPalindrome(word);

            //assert 
            Assert.Equal(expected, actual);

        }
    }
}

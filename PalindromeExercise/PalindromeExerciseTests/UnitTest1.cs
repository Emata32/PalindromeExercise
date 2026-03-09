using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("car", false)]
        public void Mytest(string word, bool expected)
        {
            // arrange
            var tester = new WordSmith();
            

            //act
            var actual = tester.IsPalindrome(word);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}

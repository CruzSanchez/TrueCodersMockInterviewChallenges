using TrueCodersMockInterviewChallenges.Library;

namespace TrueCodersMockInterviewChallenges.Tests
{
    public class ChallengeTests
    {
        [Theory]
        [InlineData(0, new int[] { })] // Edge case: n is 0, should return empty array
        [InlineData(1, new int[] { 1 })] // Smallest positive n
        [InlineData(2, new int[] { 1, 2 })] // Small n
        [InlineData(5, new int[] { 1, 2, 3, 4, 5 })] // Example given in the prompt
        [InlineData(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })] // Mid-range n
        [InlineData(20, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })] // Larger n
        [InlineData(100, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })] // Larger n, practical limits test
        [InlineData(15, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })] // Moderate n
        [InlineData(3, new int[] { 1, 2, 3 })] // Very small n
        [InlineData(25, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 })] // Small to moderate n
        public void Should_GenerateSequence(int n, int[] expected)
        {
            //Arrange
            var challenge = new Challenge();
            int[] actual = null; //This is for getting rid of compile error - ignore

            //Act
            actual = challenge.GenerateSequence(n); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("y", 0)] // y is not a vowel
        [InlineData("", 0)] // Edge case: empty string should return 0
        [InlineData("hello", 2)] // Simple case with lowercase vowels
        [InlineData("HELLO", 2)] // Simple case with uppercase vowels
        [InlineData("bcdfghjklmnpqrstvwxyz", 0)] // No vowels
        [InlineData("AEIOU", 5)] // Only vowels, all uppercase
        [InlineData("aeiou", 5)] // Only vowels, all lowercase
        [InlineData("12345", 0)] // Numerical input, no vowels
        [InlineData("bcdfgAEIOU", 5)] // Mixed case, all vowels in the middle
        [InlineData("Today is a sunny day", 6)] // Sentence with spaces and vowels
        [InlineData("The quick brown fox jumps over the lazy dog", 11)] // Complex sentence with vowels
        public void Should_CountVowels(string data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.CountVowels(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 0)] // Edge case: empty array should return 0
        [InlineData(new int[] { 1 }, 1)] // Array with a single element
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)] // Array with ascending order
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 5)] // Array with descending order
        [InlineData(new int[] { 3, 1, 10, 7, 6 }, 10)] // Example given in the prompt
        [InlineData(new int[] { 0, -1, -2, -3 }, 0)] // Array with non-positive numbers
        [InlineData(new int[] { -1, -3, -5, -7 }, -1)] // Array with negative numbers
        [InlineData(new int[] { 100, 200, 300, 400, 500 }, 500)] // Array with large numbers
        [InlineData(new int[] { 10, 10, 10, 10 }, 10)] // Array with identical elements
        [InlineData(new int[] { 1, 99, 100, 99, 1 }, 100)] // Array with the largest number in the middle
        public void Should_FindLargest(int[] data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            actual = challenge.FindLargest(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { }, 0)] // Edge case: empty array should return 0
        [InlineData(new int[] { 1, 0 }, 2)] // Simplest non-empty array with one 1 and one 0
        [InlineData(new int[] { 1, 1, 1, 1 }, 4)] // Array containing only 1s
        [InlineData(new int[] { 0, 0, 0, 0 }, 4)] // Array containing only 0s
        [InlineData(new int[] { 1, 2, 3, 4, 5, 0 }, 2)] // Array with one 1 and one 0 among other numbers
        [InlineData(new int[] { 2, 2, 2 }, 0)] // Array with no 1s or 0s
        [InlineData(new int[] { 1, 1, 0, 3, 0, 0, 2, 1, 2, 3, 5 }, 6)] // Example given in the prompt
        [InlineData(new int[] { 1, 0, 1, 0, 1, 0 }, 6)] // Array with alternating 1s and 0s
        [InlineData(new int[] { 0, 1, 2, 2, 1, 0, 3, 3, 0, 1, 2, 0, 1 }, 8)] // Mixed array with several 1s and 0s
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4, 3, 2 }, 0)] // Array with no 1s or 0s, only higher numbers
        public void Should_FindZerosAndOnes(int[] data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.FindZerosAndOnes(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { true, true, false, false }, 2)]
        [InlineData(new bool[] { }, 0)] // Edge case: empty array should return 0
        [InlineData(new bool[] { false }, 1)] // Single false element
        [InlineData(new bool[] { true }, 0)] // Single true element
        [InlineData(new bool[] { false, false, false }, 3)] // All elements are false
        [InlineData(new bool[] { true, true, true }, 0)] // All elements are true
        [InlineData(new bool[] { true, false, true, false, true }, 2)] // Alternating elements
        [InlineData(new bool[] { false, false, true, false, true, false }, 4)] // Majority false
        [InlineData(new bool[] { true, true, true, true, false }, 1)] // Only one false at the end
        [InlineData(new bool[] { false, true, true, true, true }, 1)] // Only one false at the beginning
        [InlineData(new bool[] { true, false, false, false, false, true, false }, 5)] // Multiple falses with trues at the ends
        public void Should_CountFalse(bool[] data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.CountFalse(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 5, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(-1, 1, new int[] { -1, 0, 1 })] // Includes negative, zero, and positive
        [InlineData(1, 2, new int[] { 1, 2 })] // Minimum range with two different numbers
        [InlineData(-10, -1, new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1 })] // Negative range
        [InlineData(100, 103, new int[] { 100, 101, 102, 103 })] // Small positive range
        [InlineData(-2, 2, new int[] { -2, -1, 0, 1, 2 })] // Symmetric range around zero
        [InlineData(999, 1002, new int[] { 999, 1000, 1001, 1002 })] // Edge case around a milestone number (1000)
        [InlineData(-100, -95, new int[] { -100, -99, -98, -97, -96, -95 })] // Larger negative range
        [InlineData(50, 55, new int[] { 50, 51, 52, 53, 54, 55 })] // Mid-sized range
        [InlineData(-3, 3, new int[] { -3, -2, -1, 0, 1, 2, 3 })] // Larger symmetric range around zero
        public void Should_BeBetweenTwoInts(int a, int b, int[] expected)
        {
            //Arrange
            var challenge = new Challenge();
            int[] actual = null; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.CountFalse(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

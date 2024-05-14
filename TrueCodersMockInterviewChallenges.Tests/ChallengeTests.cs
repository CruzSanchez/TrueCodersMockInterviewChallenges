using TrueCodersMockInterviewChallenges.Library;

namespace TrueCodersMockInterviewChallenges.Tests
{
    public class ChallengeTests
    {
        [Theory]
        [InlineData(5, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(0, new int[] { })]
        public void Should_GenerateSequence(int n, int[] expected)
        {
            //Arrange
            var challenge = new Challenge();
            int[] actual = null; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.GenerateSequence(n); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aeiou", 5)]
        [InlineData("y", 0)]
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
        [InlineData(new[] { 3, 1, 10, 7, 6 }, 10)]
        [InlineData(new int[0], 0)]
        public void Should_FindLargest(int[] data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.FindLargest(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 0, 3, 0, 0, 2, 1, 2, 3, 5 }, 6)]
        [InlineData(new int[0], 0)]
        public void Should_FindZerosAndOnes(int[] data, int expected)
        {
            //Arrange
            var challenge = new Challenge();
            int actual = 0; //This is for getting rid of compile error - ignore

            //Act
            //actual = challenge.FindLargest(data); //This is for getting rid of compile error **uncomment in front of actual**

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { true, true, false, false }, 2)]
        [InlineData(new bool[0], 0)]
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
    }
}

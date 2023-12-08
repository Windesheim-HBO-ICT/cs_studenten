
namespace StringCalculator_NUnitTests
{
    public class Tests
    {
        [TestCase("1,2,3", 6)]
        [TestCase("2,-20", -18)]
        [TestCase("400", 400)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", 55)]
        public void Add_Numbers_ReturnsSum(string input, int expectedResult)
        {
            //Arrange
            StringCalculator stringCalculator = new StringCalculator();
            int actualResult = 0;

            //Act
            actualResult = stringCalculator.Add(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase("this is invalid", typeof(FormatException))]
        [TestCase("a,1", typeof(FormatException))]
        public void Add_InvalidArgument_ReturnsException(string input, Type expectedException)
        {
            //Arrange
            StringCalculator calculator = new StringCalculator();
            //Act & Assert
            Assert.Throws(expectedException, () => calculator.Add(input));
        }

    }
}
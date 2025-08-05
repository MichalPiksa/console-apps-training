namespace CalculatorVersion3.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Adding_2_And_5_Returns_7()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.number1 = 2;
            calculator.number2 = 5;

            // Act
            calculator.Addition();

            // Assert
            Assert.Equal(7, calculator.result);
        }

        [Fact]
        public void Division_By_Zero()
        {
            // Arrange
            var calculator = new Calculator();
            calculator.number1 = 5;
            calculator.number2 = 0;

            // Act
            calculator.Division();

            // Assert
            Assert.Equal(0, calculator.result);
        }
    }
}

using Calculations;
namespace Calculator_Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoInttValues_ReturnsInt()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Add(1, 1);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZerp()
        {
            var calc = new Calculator();

            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = new Calculator();

            Assert.Contains(13, calc.FiboNumbers);
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotContain4()
        {
            var calc = new Calculator();

            Assert.DoesNotContain(4, calc.FiboNumbers);
        }
    }
}
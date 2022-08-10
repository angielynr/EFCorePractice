using Calculations;
using Xunit.Abstractions;

namespace Calculator_Tests
{
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            memoryStream = new MemoryStream();
        }
        [Fact]
        public void Add_GivenTwoInttValues_ReturnsInt()
        {
            //Arrange
            var calc = _calculatorFixture.Calc;

            //Act
            var result = calc.Add(1, 1);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZerp()
        {
            var calc = _calculatorFixture.Calc;

            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = _calculatorFixture.Calc;

            Assert.Contains(13, calc.FiboNumbers);
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotContain4()
        {
            var calc = _calculatorFixture.Calc;

            Assert.DoesNotContain(4, calc.FiboNumbers);
        }
    }
}
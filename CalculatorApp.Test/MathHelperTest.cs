using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathFormulas();

            int x = 1;
            int y = 2;

            bool xResult = calculator.IsEven(x);
            bool yResult = calculator.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 3, 2)]
        public void DiffTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            int result = calculator.Diff(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 6)]
        [InlineData(new int[3] { -4, -6, -10 }, -20)]
        public void SumTest(int[] values, int expectedValue)
        {
            var calculator = new MathFormulas();
            int result = calculator.Sum(values);
            Assert.Equal(expectedValue, result);
        }

        //[Theory(Skip = "All good.")]
        [Theory]
        [InlineData(2, 4, 6)]
        [InlineData(1, 4, 5)]
        public void AddTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            int result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[3] { 3, 6, 9 }, 6)]
        public void AverageTest(int[] values, int expectedValue)
        {
            var calculator = new MathFormulas();
            double result = calculator.Average(values);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(MathFormulas.Data), MemberType = typeof(MathFormulas))]
        public void Add_MemberData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            int result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [ClassData(typeof(MathFormulas))]
        public void Add_ClassData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            int result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }
    }
}
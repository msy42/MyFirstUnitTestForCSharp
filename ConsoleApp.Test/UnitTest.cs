using Xunit;

namespace ConsoleApp.Test
{
    public class UnitTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Assert.Equal(0, result);
        }
    }
}

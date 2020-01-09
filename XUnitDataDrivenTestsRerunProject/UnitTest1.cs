using Xunit;

namespace XUnitDataDrivenTestsProject
{
    public class UnitTest1
    {
        private static int counter = 1;

        [Theory]
        [Trait("Priority", "0")]
        [InlineData(1)]
        [InlineData(2)]
        public void Test1(int data)
        {
            counter++;
            Assert.True(1 == 1);
        }

        [Theory]
        [Trait("Priority", "0")]
        [InlineData(1)]
        [InlineData(2)]
        public void Test2(int data)
        {
            Assert.True(counter == 1);
        }
    }
}

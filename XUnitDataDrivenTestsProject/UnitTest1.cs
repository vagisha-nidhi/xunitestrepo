using Xunit;

namespace XUnitDataDrivenTestsProject
{
    public class UnitTest1
    {
        [Theory]
        [Trait("Priority", "0")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test1(int data)
        {
            Assert.True(1 == 1);
        }
    }
}

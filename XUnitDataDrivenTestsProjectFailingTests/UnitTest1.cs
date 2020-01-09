using Xunit;

namespace XUnitDataDrivenTestsProject
{
    public class UnitTest1
    {
        [Theory]
        [Trait("Priority", "0")]
        [InlineData(1)]
        [InlineData(2)]
        public void Test1(int data)
        {
            Assert.True(data == 1);
        }
    }
}

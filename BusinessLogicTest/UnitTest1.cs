using BusinessLogic;
using Moq;

namespace BusinessLogicTest
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("Hello", "BarHello")]
        [InlineData("Kode", "BarKode")]
        public void Test1(string foo, string expected)
        {
            // Arrange
            var fooMock = new Mock<IFoo>();
            fooMock.Setup(x => x.GetName()).Returns(foo);

            IBar sut = new Bar(fooMock.Object);

            // Act
            var actual = sut.GetName();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
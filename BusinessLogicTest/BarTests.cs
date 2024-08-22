using BusinessLogic;
using Moq;

namespace BusinessLogicTest
{
    public class BarTests
    {
        
        [Theory]
        [InlineData("Hello", "BarHello")]
        [InlineData("Kode", "BarKode")]
        public void Test1(string foo, string expected) // Given-When-Then / Gherkin / Specflow
        {
            // Arrange
            var fooMock = new Mock<IFoo>();
            fooMock.Setup(x => x.GetName(It.IsAny<string>())).Returns(foo);

            IBar sut = new Bar(fooMock.Object);

            // Act
            var actual = sut.GetName();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
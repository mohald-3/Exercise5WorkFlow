using API.Controllers;
// adding this comment to test my auto-labeler
namespace Test
{
    public class Tests
    {
        public class MathControllerTests
        {
            [Test]
            public void Add_ReturnsCorrectSum()
            {
                // Arrange
                var controller = new MathController();
                int x = 2;
                int y = 3;

                // Act
                int result = controller.Add(x, y);

                // Assert
                Assert.That(result, Is.EqualTo(5));
            }
        }
    }
}

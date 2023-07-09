using Codec_Assignment.Navigations;

namespace Codec_AssignmentTests.Navigations
{
    public class NavigateNorthTests
    {
        [Fact]
        public void Navigate_ShouldIncrementYCoordinate()
        {
            // Arrange
            var navigateNorth = new NavigateNorth();
            int x = 1;
            int y = 1;

            // Act
            navigateNorth.Navigate(ref x, ref y);

            // Assert
            Assert.Equal(1, x);
            Assert.Equal(2, y);
        }
    }
}
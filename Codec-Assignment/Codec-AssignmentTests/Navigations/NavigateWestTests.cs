using Codec_Assignment.Navigations;

namespace Codec_AssignmentTests.Navigations
{
    public class NavigateWestTests
    {
        [Fact]
        public void Navigate_ShouldDecrementXCoordinate()
        {
            // Arrange
            var navigateWest = new NavigateWest();
            int x = 1;
            int y = 1;

            // Act
            navigateWest.Navigate(ref x, ref y);

            // Assert
            Assert.Equal(0, x);
            Assert.Equal(1, y);
        }
    }
}


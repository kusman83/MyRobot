using Codec_Assignment.Navigations;

namespace Codec_AssignmentTests.Navigations
{
    public class NavigateEastTests
    {
        [Fact]
        public void Navigate_ShouldIncrementXCoordinate()
        {
            // Arrange
            var navigateEast = new NavigateEast();
            int x = 1;
            int y = 1;

            // Act
            navigateEast.Navigate(ref x, ref y);

            // Assert
            Assert.Equal(2, x);
            Assert.Equal(1, y);
        }
    }
}

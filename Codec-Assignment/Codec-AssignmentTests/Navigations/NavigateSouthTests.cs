using Codec_Assignment.Navigations;

namespace Codec_AssignmentTests.Navigations
{
    public class NavigateSouthTests
    {
        [Fact]
        public void Navigate_ShouldDecrementYCoordinate()
        {
            // Arrange
            var navigateSouth = new NavigateSouth();
            int x = 1;
            int y = 1;

            // Act
            navigateSouth.Navigate(ref x, ref y);

            // Assert
            Assert.Equal(1, x);
            Assert.Equal(0, y);
        }
    }
}

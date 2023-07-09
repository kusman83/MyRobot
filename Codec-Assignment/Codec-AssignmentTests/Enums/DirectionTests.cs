using Codec_Assignment.Enums;

namespace Codec_AssignmentTests.Enums
{
    public class DirectionTests
    {
        [Theory]
        [InlineData(Direction.West, 1)]
        [InlineData(Direction.North, 2)]
        [InlineData(Direction.East, 3)]
        [InlineData(Direction.South, 4)]
        public void EnumValues_ShouldHaveCorrectNumericValues(Direction direction, int expectedValue)
        {
            // Assert
            Assert.Equal(expectedValue, (int)direction);
        }
    }
}


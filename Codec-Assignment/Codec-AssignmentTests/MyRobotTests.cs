using Codec_Assignment;

namespace Codec_AssignmentTests
{
    public class MyRobotTests
    {
        [Fact]
        public void Navigate_WithValidCommands_ShouldMoveRobotCorrectly()
        {
            // Arrange
            int maxX = 5;
            int maxY = 5;
            MyRobot robot = new MyRobot(maxX, maxY);

            // Act
            robot.Navigate("FFRFLFLF");

            // Assert
            string finalPosition = robot.GetCurrentPosition();
            Assert.Equal("1,4,West", finalPosition);
        }

        [Fact]
        public void Navigate_WithInvalidCommand_ShouldThrowArgumentException()
        {
            // Arrange
            int maxX = 5;
            int maxY = 5;
            MyRobot robot = new MyRobot(maxX, maxY);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => robot.Navigate("FFXF"));
        }

        [Fact]
        public void GetPosition_ShouldReturnInitialPosition()
        {
            // Arrange
            int maxX = 5;
            int maxY = 5;
            MyRobot robot = new MyRobot(maxX, maxY);

            // Act
            string position = robot.GetCurrentPosition();

            // Assert
            Assert.Equal("1,1,North", position);
        }

        [Fact]
        public void GetPosition_ShouldReturnUpdatedPositionAfterNavigation()
        {
            // Arrange
            int maxX = 5;
            int maxY = 5;
            MyRobot robot = new MyRobot(maxX, maxY);

            // Act
            robot.Navigate("RFFLF");
            string position = robot.GetCurrentPosition();

            // Assert
            Assert.Equal("3,2,North", position);
        }
    }
}
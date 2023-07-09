using Codec_Assignment.Enums;
using Codec_Assignment.Navigations;

namespace Codec_Assignment
{
    public class MyRobot
    {

        private int x;

        private int y;

        private char direction;

        private int maxX;

        private int maxY;

        private INavigate navigate;


        public MyRobot(int maxX, int maxY)
        {

            x = 1;

            y = 1;

            direction = 'N';

            this.maxX = maxX < 0 ? throw new ArgumentException("Invalid plateau size.") : maxX;
            this.maxY = maxY < 0 ? throw new ArgumentException("Invalid plateau size.") : maxY;

            navigate = new NavigateNorth();
        }


        public void Navigate(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException("Invalid command: " + command);
                }
            }
        }

        private void TurnLeft()
        {
            switch (direction)
            {
                case 'N':
                    direction = 'W';
                    navigate = new NavigateWest();
                    break;
                case 'W':
                    direction = 'S';
                    navigate = new NavigateSouth();
                    break;
                case 'S':
                    direction = 'E';
                    navigate = new NavigateEast();
                    break;
                case 'E':
                    direction = 'N';
                    navigate = new NavigateNorth();
                    break;
            }
        }

        private void TurnRight()
        {
            switch (direction)
            {
                case 'N':
                    direction = 'E';
                    navigate = new NavigateEast();
                    break;
                case 'E':
                    direction = 'S';
                    navigate = new NavigateSouth();
                    break;
                case 'S':
                    direction = 'W';
                    navigate = new NavigateWest();
                    break;
                case 'W':
                    direction = 'N';
                    navigate = new NavigateNorth();
                    break;
            }
        }

        private void MoveForward()
        {
            int tempX = x;
            int tempY = y;

            navigate.Navigate(ref tempX, ref tempY);

            if (tempX >= 1 && tempX <= maxX && tempY >= 1 && tempY <= maxY)
            {
                x = tempX;
                y = tempY;
            }
        }

        public string GetCurrentPosition()
        {
            string directionString = GetDirectionString();

            return $"{x},{y},{directionString}";
        }

        private string GetDirectionString()
        {
            return direction switch
            {
                'W' => nameof(Direction.West),
                'N' => nameof(Direction.North),
                'E' => nameof(Direction.East),
                'S' => nameof(Direction.South),
                _ => throw new InvalidOperationException($"Unknown direction: {direction}")
            };
        }
    }
}
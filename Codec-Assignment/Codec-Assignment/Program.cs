using Codec_Assignment;

int maxX = 5;
int maxY = 5;
string commands = "FFRFLFLF";

MyRobot robot = new MyRobot(maxX, maxY);
robot.Navigate(commands);
string finalPosition = robot.GetCurrentPosition();

Console.WriteLine("Result: " + finalPosition);
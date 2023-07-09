namespace Codec_Assignment.Navigations
{
    public class NavigateNorth : INavigate
    {
		
        public void Navigate(ref int x, ref int y)
        {
            y++;
        }
    }
}


namespace Codec_Assignment.Navigations
{
    public class NavigateSouth : INavigate
    {
        public void Navigate(ref int x, ref int y)
        {
            y--;
        }
    }
}


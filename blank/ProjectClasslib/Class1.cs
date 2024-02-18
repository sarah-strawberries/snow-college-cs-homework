namespace ProjectClasslib;
public struct Design
{
    public enum BackgroundColor
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Pink
    }
    public int fontSize;
    public string? Title;
    public BackgroundColor BgColor;
}
public class WebDesign<T>
 where T : class
{
    public bool DoSomething { get; set; }

}

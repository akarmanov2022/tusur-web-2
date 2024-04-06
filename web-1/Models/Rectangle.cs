namespace web_1.Models;

public class Rectangle
{
    public double Height { set; get; }
    public double Width { set; get; }

    public double Area()
    {
        return Height * Width;
    }
}
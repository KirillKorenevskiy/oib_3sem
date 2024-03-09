interface IFigure
{
    void Print();
}

class Rectangle : IFigure
{
    private int x;
    private int y;
    private int width;
    private int height;
    private string color;

    public Rectangle(int x, int y, int width, int height, string color)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.color = color;
    }

    public Rectangle()
    {
        x = 0;
        y = 0;
        width = 0;
        height = 0;
        color = "";
    }

    public Rectangle(int width, int height, string color) : this(0, 0, width, height, color)
    {
    }

    public void Print()
    {
        Console.WriteLine($"Rect: x={x}, y= {y}, width = {width}, height = {height}, color = {color}");
    }

    public override string ToString()
    {
        return $"Rect: x={x}, y= {y}, width = {width}, height = {height}, color = {color}";
    }

    public static Rectangle operator +(Rectangle rect, int value)
    {
        rect.width += value;
        rect.height += value;
        return rect;
    }

    public int CulcArea() {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Rectangle> rectangles = new List<Rectangle>()
        {
            new Rectangle(2, 3, 10, 5, "Red"),
            new Rectangle(5, 2, 7, 7, "Blue"),
            new Rectangle(1, 4, 8, 4, "Green"),
            new Rectangle(3, 1, 6, 9, "Yellow"),
            new Rectangle(4, 5, 9, 3, "Orange"),
            new Rectangle(6, 6, 3, 8, "Purple")
        };

        rectangles[0] += 2;
        rectangles[0].Print();
    }
}
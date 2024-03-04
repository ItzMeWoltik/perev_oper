namespace perev_oper;

public class MyPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static MyPoint operator +(MyPoint point1, MyPoint point2)
    {
        return new MyPoint(point1.X + point2.X, point1.Y + point2.Y);
    }

    public static MyPoint operator -(MyPoint point1, MyPoint point2)
    {
        return new MyPoint(point1.X - point2.X, point1.Y - point2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
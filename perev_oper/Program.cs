using perev_oper;

class Program
{
    static void Main(string[] args)
    {
        MyPoint point1 = new MyPoint(10, 20);
        MyPoint point2 = new MyPoint(5, 10);

        MyPoint sum = point1 + point2;
        MyPoint difference = point1 - point2;

        Console.WriteLine("Додавання:");
        Console.WriteLine($"{point1} + {point2} = {sum}");

        Console.WriteLine("\nВіднімання:");
        Console.WriteLine($"{point1} - {point2} = {difference}");

        Console.ReadLine();
    }
}
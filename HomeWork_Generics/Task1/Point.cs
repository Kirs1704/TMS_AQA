namespace HomeWork_Generics.Task1;

public class Point
{
    private int X { get; set; }
    private int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void ShowPoint()
    {
        Console.WriteLine($"Позиция точки по оси X: {X}\nПо оси Y: {Y}");
    }
}
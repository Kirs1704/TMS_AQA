namespace HomeWork_Generics.Task1;

public class Point
{
    private int x;
    private int y;

    // конструктор с двумя параметрами
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // свойства доступа к внутренним полям
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public void ShowPoint()
    {
        Console.WriteLine($"Позиция точки по оси X: {X}\nПо оси Y: {Y}");
    }
}
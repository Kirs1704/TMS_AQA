namespace HomeWork;

public class Circle : Figure
{
    public double R { get; set; } = 5;            // реализуем ввод параметра "Радиус" через автосвойство (см. Program.cs)
    
    public override double CalculateArea()
    {
        double s = Math.PI * R * R;
        return s;
    }

    public override double CalculatePerimeter()
    {
        double p = 2 * Math.PI * R;
        return p;
    }
};

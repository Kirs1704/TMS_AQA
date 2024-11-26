namespace Task1;

public class Pryamoug
{
    // создаем свойства основания и высоты для дальнейшего подсчета площади прямоугольного треугольника по высоте и основанию
    
    public double Base { get; set; }
    public double Height { get; set; }
    
    // создаем конструктор для создания треугольника

    public Pryamoug(double Base, double Height)
    {
        if (Base <= 0 || Height <= 0)
        {
            Console.WriteLine("Значения основания и высоты треугольника должны быть больше 0!");
        }
        this.Base = Base;
        this.Height = Height;
    }
    
    // метод для подсчета площади прямоугольного треугольника

    public double getArea()
    {
        return 0.5 * Base * Height;
        
    }
    
}
namespace Task1;

public class TriangleKind
{
    public double FirstSide { get; set; }
    public double SecondSide { get; set; }
    public double BaseSide { get; set; }
    
    public double Height { get; set; }

    public TriangleKind(double firstSide, double secondSide, double baseSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        BaseSide = baseSide;
    }
    public TriangleKind(double firstSide, double secondSide, double baseSide, double height)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        BaseSide = baseSide;
        Height = height;
    }

    public string getTriangleType()
    {
        if (FirstSide == SecondSide && FirstSide != BaseSide)
        {
            Console.WriteLine("Данный треугольник равнобедренный");
            return "Равнобедренный";
        }
        else if (FirstSide == SecondSide && SecondSide == BaseSide)
        {
            Console.WriteLine("Данный треугольник равносторонний");
            return "Равноcторонний";
            
        }
        else
        {
            Console.WriteLine("Прямоугольный или разносторонний");
            return "Прямоугольный или разносторонний";
        }
    }
}
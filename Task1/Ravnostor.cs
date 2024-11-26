namespace Task1;

public class Ravnostor
{
    // у этого треугольника s будем находить через радиус описанной окружности. Нужны длины сторон и радиус описанной окружности
    public double FirstSide { get; set; }                   // здесь задаем сторону № 1
    public double SecondSide { get; set; }                  // здесь задаем сторону № 2
    public double BaseSide { get; set; }                    // здесь задаем основание
    public double Radius { get; set; }                      // радиус окружности
    public bool _isValid = true;                            // флаг для проверки условий. Если какое-то условие не пройдет, поменяется на false

    public Ravnostor(double firstSide, double secondSide, double baseSide, double radius)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        BaseSide = baseSide;
        Radius = radius;
        
        if (FirstSide <= 0 || SecondSide <= 0 || BaseSide <= 0 || Radius <= 0)
        {
            Console.WriteLine("Стороны, основание и радиус описанной окружности должны быть больше 0!");
            _isValid = false;
        }
        else if (FirstSide != SecondSide || FirstSide != BaseSide) //проверяем, что все стороны равны
        {
            Console.WriteLine("Стороны равностороннего треугольника должны быть равны!");
            _isValid = false;
        }
        
    }

    public double GetArea()
    {
        if (_isValid==false)
        {
            Console.WriteLine("Данные не верны! Проверьте правильность входных параметров");
            return 0;
        }
        else
        {
            return (3 * Math.Sqrt(3) / 4) * Math.Pow(Radius, 2);
        }
    }
}
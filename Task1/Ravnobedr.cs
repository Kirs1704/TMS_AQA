namespace Task1;

public class Ravnobedr
{
    // У этого треугольника будем находить через радиус вписанной окружности. Для этого нам нужны 3 стороны и радиус вписанной окружности
    public double FirstSide { get; set; }                   // здесь задаем сторону № 1
    public double SecondSide { get; set; }                  // здесь задаем сторону № 2
    public double BaseSide { get; set; }                        // здесь задаем основание
    public double Radius { get; set; }                      // радиус окружности
    public bool _isValid = true;
    
    // Создаем конструктор для треугольника

    public Ravnobedr(double firstSide, double secondSide, double baseSide, double radius)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        BaseSide = baseSide;
        Radius = radius;
        
        if (FirstSide <= 0 || SecondSide <= 0 || BaseSide <= 0 || Radius <= 0)
        {
            Console.WriteLine("Стороны, основание и радиус вписанной окружности должны быть больше 0!");
            _isValid = false;
        }
        else if (FirstSide!=SecondSide) //стороны должны быть равны, он же равнобедренный
        {
            Console.WriteLine("Стороны треугольника должны быть равны, он же равнобедренный, ну ты че!");
            _isValid = false;
        }
        else if (BaseSide >= (2*FirstSide)) // сумма двух сторон равнобедренного треугольника д.б. больше основания
        {
            Console.WriteLine("Cумма двух сторон равнобедренного треугольника д.б. больше основания");
            _isValid = false;
        }
        
        
    }
    
    // создаем метод для вычисления площади через радиус вписанной окружности
    public double GetArea()
    {
        if (_isValid) // если предыдущие условия прошли успешно, тогда это значение д.б. true
        {
            // для данного способа сначала находим полупериметр (это то что ниже в скобках). А потом умножаем на Radius.
            return ((FirstSide + SecondSide + BaseSide) / 2) * Radius; 
        }
        else
        {
            Console.WriteLine("Данные треугольника не корректны");
            return 0;
        }


    }
}
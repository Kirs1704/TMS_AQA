namespace HomeWork;

public class Triangle : Figure // создали класс Triangle и унаследовались от абстрактного класса Figure
{

    // блок полей
    public double side1;      // создали переменную для стороны 1
    public double side2;      // создали переменную для стороны 2
    public double side3;      // создали переменную для стороны 3

    // блок конструктора
    public Triangle(double side1, double side2, double side3)  // создаем конструктор для того, чтобы в момент создания объекта класса требовался ввод трех сторон треугольника
    {
        this.side1 = side1;  // записываем введенные значения для сторон 1, 2 и 3 в переменные из блока полей
        this.side2 = side2;
        this.side3 = side3;
    }
    
    // блок метода
    public override double CalculateArea()            // реализуем метод из родительского класса исходя из условий текущего класса
    {
        double P = side1 + side2 + side3;      // эта строка и далее просто реализация формул для подсчета площади треугольника
        double p = P / 2;
        double S = Math.Sqrt(p*((p - side1) * (p - side2) * (p - side3)));
        return S;
    }

    public override double CalculatePerimeter()
    {
        double P = side1 + side2 + side3;
        return P;
    }
}
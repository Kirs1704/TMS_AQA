namespace HomeWork;

public abstract class Figure           // Создали абстрактный класс (шаблон для других производных классов)
{
    public abstract double CalculateArea();         // Реализовали абстрактный метод, который в каждом производном классе будет реализован индивидуально

    public abstract double CalculatePerimeter();    // Реализовали абстрактный метод, который в каждом производном классе будет реализован индивидуально
}
// далее см. класс Triangle
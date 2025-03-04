namespace Generics;

public class Company<T>  // если сделать класс обобщенным, можно передавать в кач. параметров другой обобщенный класс (с разными типами внутри этого класса)
{
    public T CEO { get; set; }

    public Company(T ceo)
    {
        CEO = ceo;
    }
}